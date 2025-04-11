import 'package:flutter/services.dart';
import 'package:bantaybahamobile/signin_screen.dart';
import 'package:bantaybahamobile/live_screen.dart';
import 'package:bantaybahamobile/waterlevel_screen.dart';
import 'package:flutter/material.dart';
import 'package:firebase_auth/firebase_auth.dart';
import 'package:cloud_firestore/cloud_firestore.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  final FirebaseFirestore _firestore = FirebaseFirestore.instance;
  bool isSafe = false;
  String userName = "Loading...";
  String userAddress = "No Address Provided";
  String userContact = "No Contact Provided";

  final List<String> emergencyHotlines = [
    'Area 5 - 09384552877', 
    'MDRRMO - 09696144825', 
    'BFP - 09516047279' 
  ];

  @override
  void initState() {
    super.initState();
    _fetchUserData();
  }

  void _fetchUserData() async {
    User? user = FirebaseAuth.instance.currentUser;

    if (user != null) {
      String userId = user.uid;
      DocumentSnapshot userDoc = await _firestore.collection('users').doc(userId).get();

      if (userDoc.exists) {
        setState(() {
          userName = userDoc.get('name') ?? "User";
          userAddress = userDoc.get('address') ?? "No Address Provided";
          userContact = userDoc.get('contact') ?? "No Contact Provided";
        });
      } else {
        print("User document does not exist.");
      }
    } else {
      print("No user is logged in.");
    }
  }

  void _toggleStatus() async {
    User? user = FirebaseAuth.instance.currentUser;

    if (user != null) {
      String userId = user.uid;
      DocumentReference userStatusRef = _firestore.collection('users').doc(userId);

      await userStatusRef.update({
        'status': isSafe ? 'safe' : 'unsafe',
      }).then((_) {
        setState(() {
          isSafe = !isSafe;
        });
      }).catchError((error) {
        print("Error updating status: $error");
      });
    } else {
      print("No user is logged in.");
    }
  }

  void _requestRescue() async {
    User? user = FirebaseAuth.instance.currentUser;

    if (user != null) {
      String userId = user.uid;

      try {
        DocumentSnapshot userDoc = await _firestore.collection('users').doc(userId).get();

        if (userDoc.exists) {
          String name = userDoc.get('name') ?? "User";
          String address = userDoc.get('address') ?? "No Address Provided";
          String contact = userDoc.get('contact') ?? "No Contact Provided";

          await _firestore.collection('rusers').add({
            'name': name,
            'address': address,
            'contact': contact,
            'timestamp': FieldValue.serverTimestamp(),
          });

          ScaffoldMessenger.of(context).showSnackBar(
            const SnackBar(content: Text("Rescue request sent successfully")),
          );
        } else {
          print("User document does not exist in 'users' collection.");
        }
      } catch (error) {
        print("Error sending rescue request: $error");
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(content: Text("Failed to send rescue request")),
        );
      }
    } else {
      print("No user is logged in.");
    }
  }

  void _copyToClipboard(String number) {
    Clipboard.setData(ClipboardData(text: number.trim()));
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(content: Text('Hotline $number copied to clipboard')),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          'Hello, $userName!',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
        backgroundColor: Colors.blue[800],
      ),
      body: Container(
        decoration: const BoxDecoration(
          gradient: LinearGradient(
            colors: [Color(0xFF2196F3), Color(0xFF1565C0)], 
            begin: Alignment.topCenter,
            end: Alignment.bottomCenter,
          ),
        ),
        child: Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              const SizedBox(height: 10),

              // Emergency Hotlines Section
              Column(
                children: List.generate(emergencyHotlines.length, (index) {
                  return Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      Text(
                        emergencyHotlines[index],
                        style: const TextStyle(fontSize: 16, color: Colors.white),
                      ),
                      IconButton(
                        onPressed: () => _copyToClipboard(emergencyHotlines[index]),
                        icon: const Icon(Icons.copy, color: Colors.white),
                      ),
                    ],
                  );
                }),
              ),

              const SizedBox(height: 15),

              ElevatedButton(
                onPressed: _toggleStatus,
                style: ElevatedButton.styleFrom(
                  backgroundColor: isSafe ? Colors.red : Colors.green,
                  padding: const EdgeInsets.symmetric(horizontal: 50, vertical: 15),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(30),
                  ),
                ),
                child: Text(
                  isSafe ? "I'm Unsafe" : "I'm Safe",
                  style: const TextStyle(
                    fontSize: 18,
                    color: Colors.white,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),

              const SizedBox(height: 15),

              ElevatedButton(
                onPressed: _requestRescue,
                style: ElevatedButton.styleFrom(
                  backgroundColor: Colors.red,
                  padding: const EdgeInsets.symmetric(horizontal: 50, vertical: 15),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(30),
                  ),
                ),
                child: const Text(
                  "Request Rescue",
                  style: TextStyle(
                    fontSize: 18,
                    color: Colors.white,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),

              const SizedBox(height: 20),
              _buildNavButton(context, "Go to Water Level Screen", WaterlevelScreen()),
              const SizedBox(height: 15),
              _buildNavButton(context, "Go to Live Cam Screen", const LiveCamScreen()),
              const SizedBox(height: 15),
              ElevatedButton(
                onPressed: () {
                  FirebaseAuth.instance.signOut().then((value) {
                    print("Signed Out");
                    Navigator.pushReplacement(
                      context,
                      MaterialPageRoute(builder: (context) => const SignInScreen()),
                    );
                  });
                },
                style: ElevatedButton.styleFrom(
                  backgroundColor: Colors.white,
                  padding: const EdgeInsets.symmetric(horizontal: 50, vertical: 15),
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(30),
                  ),
                ),
                child: const Text(
                  "Logout",
                  style: TextStyle(
                    fontSize: 18,
                    color: Colors.black87,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildNavButton(BuildContext context, String label, Widget screen) {
    return ElevatedButton(
      onPressed: () {
        Navigator.push(
          context,
          MaterialPageRoute(builder: (context) => screen),
        );
      },
      style: ElevatedButton.styleFrom(
        backgroundColor: Colors.white,
        padding: const EdgeInsets.symmetric(horizontal: 50, vertical: 15),
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(30),
        ),
      ),
      child: Text(
        label,
        style: const TextStyle(
          fontSize: 18,
          color: Colors.black87,
          fontWeight: FontWeight.bold,
        ),
      ),
    );
  }
}
