import 'package:flutter/material.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:firebase_messaging/firebase_messaging.dart';
import 'package:flutter_local_notifications/flutter_local_notifications.dart';
import 'signin_screen.dart';

// Initialize the notification plugin
FlutterLocalNotificationsPlugin flutterLocalNotificationsPlugin =
    FlutterLocalNotificationsPlugin();

// Initialize Firebase
void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await Firebase.initializeApp();

  // Initialize Firebase Messaging
  FirebaseMessaging messaging = FirebaseMessaging.instance;

  // Retrieve FCM token (for logging and debugging)
  String? token = await messaging.getToken();
  print("Device FCM Token: $token");

  // Set up background message handler
  FirebaseMessaging.onBackgroundMessage(_backgroundMessageHandler);

  // Initialize local notifications
  const AndroidInitializationSettings androidInitializationSettings =
      AndroidInitializationSettings('@mipmap/ic_launcher');
  final InitializationSettings initializationSettings =
      InitializationSettings(android: androidInitializationSettings);
  await flutterLocalNotificationsPlugin.initialize(initializationSettings);

  // Request permission for notifications
  NotificationSettings settings = await messaging.requestPermission();
  if (settings.authorizationStatus == AuthorizationStatus.denied) {
    print("User denied notification permissions");
  } else {
    print("Notification permissions granted");
  }

  // Listen for foreground messages
  FirebaseMessaging.onMessage.listen((RemoteMessage message) {
    print('Received a message while in the foreground: ${message.notification?.title}');
    if (message.notification != null) {
      print('Notification title: ${message.notification?.title}');
      print('Notification body: ${message.notification?.body}');
    }
    // Show a local notification when the app is in the foreground
    _showNotification(message);
  });

  runApp(const MyApp());
}

Future<void> _showNotification(RemoteMessage message) async {
  print("Showing notification...");

  // Create a channel for Android 8.0 and above
  const AndroidNotificationDetails androidDetails = AndroidNotificationDetails(
    'flood_alerts_channel', // channel ID
    'Flood Alerts', // channel name
    channelDescription: 'Channel for flood alert notifications',
    importance: Importance.high,
    priority: Priority.high,
    showProgress: false,
    enableVibration: true,
  );

  const NotificationDetails platformDetails = NotificationDetails(
    android: androidDetails,
  );

  // Show the notification
  await flutterLocalNotificationsPlugin.show(
    0, // notification ID
    message.notification?.title,
    message.notification?.body,
    platformDetails,
  );
}

Future<void> _backgroundMessageHandler(RemoteMessage message) async {
  print("Handling a background message: ${message.notification?.title}");
  // Handle the background notification (e.g., show a local notification)
  _showNotification(message);
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'BantayBahaPH',
      theme: ThemeData(
        useMaterial3: true,
        colorScheme: ColorScheme(
          brightness: Brightness.light,
          primary: Colors.blue,
          onPrimary: Colors.white,
          secondary: Colors.lightBlueAccent,
          onSecondary: Colors.white,
          surface: Colors.lightBlue[100]!,
          onSurface: Colors.blueGrey[900]!,
          error: Colors.red,
          onError: Colors.white,
        ),
        appBarTheme: const AppBarTheme(
          backgroundColor: Colors.blue,
          foregroundColor: Colors.white,
        ),
        elevatedButtonTheme: ElevatedButtonThemeData(
          style: ElevatedButton.styleFrom(
            backgroundColor: Colors.blue,
            foregroundColor: Colors.white,
          ),
        ),
        textTheme: TextTheme(
          bodyLarge: TextStyle(color: Colors.blueGrey[900], fontSize: 16),
          bodyMedium: TextStyle(color: Colors.blueGrey[800], fontSize: 14),
        ),
      ),
      home: const SignInScreen(),
    );
  }
}
