import 'package:flutter/material.dart';
import 'package:firebase_database/firebase_database.dart';
import 'dart:async';

class WaterlevelScreen extends StatefulWidget {
  const WaterlevelScreen({super.key});

  @override
  _WaterlevelScreenState createState() => _WaterlevelScreenState();
}

class _WaterlevelScreenState extends State<WaterlevelScreen> {
  final DatabaseReference _dbRef = FirebaseDatabase.instance.ref();
  Map<String, dynamic> _waterLevels = {}; // Store all water levels
  StreamSubscription? _dataSubscription;

  @override
  void initState() {
    super.initState();
    _fetchWaterLevels();
  }

  void _fetchWaterLevels() {
    _dataSubscription = _dbRef.onValue.listen((event) {
      final data = event.snapshot.value as Map?;
      if (data != null) {
        setState(() {
          _waterLevels = {
            ...data, // Include all data from the database
          };
        });
      }
    });
  }

  @override
  void dispose() {
    _dataSubscription?.cancel();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Water Levels"),
        backgroundColor: const Color.fromARGB(255, 0, 119, 182), // Deep Blue
      ),
      body: Container(
        // Apply a gradient background
        decoration: const BoxDecoration(
          gradient: LinearGradient(
            begin: Alignment.topCenter,
            end: Alignment.bottomCenter,
            colors: [
              Color(0xFF87CEEB), // Light Blue
              Color(0xFF00008B), // Dark Blue
            ],
          ),
        ),
        child: _waterLevels.isEmpty
            ? const Center(child: CircularProgressIndicator())
            : ListView.builder(
                itemCount: _waterLevels.keys.length,
                itemBuilder: (context, index) {
                  // Sort keys to display `mainWaterLevel` at the top
                  List<String> sortedKeys = _getSortedKeys();
                  String key = sortedKeys[index];
                  dynamic value = _waterLevels[key];

                  // Determine the display level (block or mainWaterLevel)
                  String displayLevel;
                  if (value is Map && value.containsKey('waterLevel')) {
                    displayLevel = value['waterLevel'].toStringAsFixed(2);
                  } else {
                    displayLevel = value?.toStringAsFixed(2) ?? "No data";
                  }

                  return Card(
                    color: const Color.fromARGB(255, 173, 216, 230), // Light Blue
                    margin: const EdgeInsets.all(10),
                    child: ListTile(
                      title: Text(
                        key,
                        style: const TextStyle(
                          fontSize: 20,
                          fontWeight: FontWeight.bold,
                          color: Color.fromARGB(255, 0, 51, 102), // Navy Blue
                        ),
                      ),
                      subtitle: Text(
                        "Water Level: $displayLevel m",
                        style: const TextStyle(
                          fontSize: 16,
                          color: Color.fromARGB(255, 0, 51, 102), // Navy Blue
                        ),
                      ),
                      trailing: Icon(
                        _getWarningIcon(double.tryParse(displayLevel) ?? 0.0),
                        color: _getIconColor(double.tryParse(displayLevel) ?? 0.0),
                      ),
                    ),
                  );
                },
              ),
      ),
    );
  }

  // Sort keys to ensure `mainWaterLevel` is displayed at the top
  List<String> _getSortedKeys() {
    List<String> keys = _waterLevels.keys.toList();
    keys.sort((a, b) {
      if (a == "mainWaterLevel") return -1; // `mainWaterLevel` comes first
      if (b == "mainWaterLevel") return 1;
      return a.compareTo(b); // Sort other blocks alphabetically
    });
    return keys;
  }

  IconData _getWarningIcon(double waterLevelValue) {
    if (waterLevelValue < 3) {
      return Icons.water_drop; // Icon representing low water level
    } else if (waterLevelValue < 5) {
      return Icons.error; // Moderate alert
    } else {
      return Icons.dangerous; // High alert
    }
  }

  // Return the color of the icon based on the water level value
  Color _getIconColor(double waterLevelValue) {
    if (waterLevelValue < 3) {
      return const Color(0xFF0000FF); // Blue for low water level
    } else if (waterLevelValue < 5) {
      return Colors.orange; // Moderate alert
    } else  {
      return Colors.red; // High alert
    }
  }
}
