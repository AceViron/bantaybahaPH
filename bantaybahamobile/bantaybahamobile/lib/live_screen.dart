import 'package:flutter/material.dart';
import 'package:firebase_auth/firebase_auth.dart';
import 'package:firebase_storage/firebase_storage.dart';
import 'dart:async';

class LiveCamScreen extends StatefulWidget {
  const LiveCamScreen({super.key});

  @override
  _LiveCamScreenState createState() => _LiveCamScreenState();
}

class _LiveCamScreenState extends State<LiveCamScreen> {
  String imageUrl = "";
  bool isLoading = true;
  Timer? _timer;

  @override
  void initState() {
    super.initState();
    _authenticateUser();
    // Start a timer to periodically check for a new image
    _timer = Timer.periodic(Duration(seconds: 3), (timer) {
      _loadImage(); // Fetch new image URL every 10 seconds
    });
  }

  // Authenticate user with Firebase
  Future<void> _authenticateUser() async {
    try {
      await FirebaseAuth.instance.signInWithEmailAndPassword(
        email: "vironacealmaden@gmail.com",
        password: "vironace123",
      );
      _loadImage();
    } catch (e) {
      print("Authentication error: $e");
    }
  }

  // Load the latest image URL from Firebase Storage
  Future<void> _loadImage() async {
    try {
      final ref = FirebaseStorage.instance.ref().child("data/photo.jpg");
      String url = await ref.getDownloadURL();

      if (url != imageUrl) { // Check if the image URL has changed
        setState(() {
          imageUrl = url;
          isLoading = false;
        });
      }
    } catch (e) {
      print("Error loading image: $e");
      setState(() {
        isLoading = false;
      });
    }
  }

  @override
  void dispose() {
    _timer?.cancel(); // Cancel the timer when the widget is disposed
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("LiveCam Screen"),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () {
            Navigator.pop(context);
          },
        ),
      ),
      body: Center(
        child: isLoading
            ? CircularProgressIndicator()
            : imageUrl.isNotEmpty
                ? Image.network(imageUrl)
                : Text("No image available"),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: _loadImage,
        tooltip: 'Refresh Image',
        child: Icon(Icons.refresh),
      ),
    );
  }
}
