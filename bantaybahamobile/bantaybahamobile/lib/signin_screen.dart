import 'package:flutter/material.dart';
import 'package:firebase_auth/firebase_auth.dart';
import 'package:firebase_messaging/firebase_messaging.dart';
import 'home_screen.dart'; // Import your HomeScreen

class SignInScreen extends StatefulWidget {
  const SignInScreen({super.key});

  @override
  State<SignInScreen> createState() => _SignInScreenState();
}

class _SignInScreenState extends State<SignInScreen> {
  final TextEditingController _passwordTextController = TextEditingController();
  final TextEditingController _emailTextController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        width: MediaQuery.of(context).size.width,
        height: MediaQuery.of(context).size.height,
        decoration: const BoxDecoration(
          gradient: LinearGradient(
            colors: [Color(0xFF2196F3), Color(0xFF1565C0)],
            begin: Alignment.topCenter,
            end: Alignment.bottomCenter,
          ),
        ),
        child: SingleChildScrollView(
          child: Padding(
            padding: EdgeInsets.fromLTRB(
                20, MediaQuery.of(context).size.height * 0.2, 28, 0),
            child: Column(
              children: <Widget>[
                const Text(
                  "BantayBaha 1K1",
                  style: TextStyle(
                    fontSize: 32,
                    fontWeight: FontWeight.bold,
                    color: Colors.white,
                  ),
                  textAlign: TextAlign.center,
                ),
                const SizedBox(height: 30),
                TextField(
                  controller: _emailTextController,
                  decoration: const InputDecoration(
                    labelText: "Enter Email",
                    labelStyle: TextStyle(color: Colors.white), // Set label color to white
                    prefixIcon: Icon(Icons.person_outline, color: Colors.white),
                    enabledBorder: UnderlineInputBorder(
                      borderSide: BorderSide(color: Colors.white),
                    ),
                    focusedBorder: UnderlineInputBorder(
                      borderSide: BorderSide(color: Colors.white),
                    ),
                  ),
                  style: const TextStyle(color: Colors.white), // Text color
                ),
                const SizedBox(height: 30),
                TextField(
                  controller: _passwordTextController,
                  decoration: const InputDecoration(
                    labelText: "Enter Password",
                    labelStyle: TextStyle(color: Colors.white), // Set label color to white
                    prefixIcon: Icon(Icons.lock_outline, color: Colors.white),
                    enabledBorder: UnderlineInputBorder(
                      borderSide: BorderSide(color: Colors.white),
                    ),
                    focusedBorder: UnderlineInputBorder(
                      borderSide: BorderSide(color: Colors.white),
                    ),
                  ),
                  obscureText: true,
                  style: const TextStyle(color: Colors.white), // Text color
                ),
                const SizedBox(height: 30),
                ElevatedButton(
                  onPressed: () async {
                    FirebaseAuth.instance
                        .signInWithEmailAndPassword(
                            email: _emailTextController.text,
                            password: _passwordTextController.text)
                        .then((value) async {
                      // Subscribe to topic upon successful sign-in
                      FirebaseMessaging messaging = FirebaseMessaging.instance;
                      await messaging.subscribeToTopic('flood-alerts');
                      print("Subscribed to flood-alerts topic");

                      Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) => const HomeScreen()),
                      );
                    }).onError((error, stackTrace) {
                      print("Error: ${error.toString()}");
                    });
                  },
                  child: const Text("Sign In"),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
