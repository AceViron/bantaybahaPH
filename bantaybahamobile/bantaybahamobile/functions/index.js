const admin = require('firebase-admin');

// Initialize Firebase Admin SDK
const serviceAccount = require('D:/dev/bantaybahamobile/bantaybaha-c0ea0-firebase-adminsdk-xwmv9-d0aa9cadd6.json');

admin.initializeApp({
  credential: admin.credential.cert(serviceAccount),
  databaseURL: 'https://bantaybaha-c0ea0-default-rtdb.firebaseio.com/',
});

// Main monitoring logic
const db = admin.database();
const ref = db.ref('mainWaterLevel');

// Topic name for all devices to subscribe to
const topic = 'flood-alerts'; // You can use a topic name like 'flood-alerts'

// Monitor the water level continuously
ref.on('value', (snapshot) => {
  const waterLevel = snapshot.val();
  console.log(`Current Water Level: ${waterLevel}`);

  // Add notification logic here
  if (waterLevel > 5.5) {
    console.log('Warning: High Water Level Detected!');

    // FCM Notification payload
    const message = {
      notification: {
        title: 'Flood Alert',
        body: `Warning: High water level detected at ${waterLevel} meters!`,
      },
      topic: topic, // Send to the 'flood-alerts' topic
    };

    // Send the notification to the topic
    admin.messaging()
      .send(message)
      .then((response) => {
        console.log('Successfully sent notification:', response);
      })
      .catch((error) => {
        console.error('Error sending notification:', error);
      });
  }
});
