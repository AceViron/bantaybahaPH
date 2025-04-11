// Import the functions you need from the SDKs
import { initializeApp } from "https://www.gstatic.com/firebasejs/10.14.1/firebase-app.js";
import { getAnalytics } from "https://www.gstatic.com/firebasejs/10.14.1/firebase-analytics.js";
import { getFirestore, setDoc, doc } from "https://www.gstatic.com/firebasejs/10.14.1/firebase-firestore.js";

// Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyBmASrJkNW6KZeBDnl9BpUUwnwEnaETots",
  authDomain: "bantaybaha-c0ea0.firebaseapp.com",
  projectId: "bantaybaha-c0ea0",
  storageBucket: "bantaybaha-c0ea0.appspot.com",
  messagingSenderId: "323604720052",
  appId: "1:323604720052:web:f7da034ba91fdcefd42ae1",
  measurementId: "G-S3L817LY22"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);

// Function to show messages
function showMessage(message, divId) {
  var messageDiv = document.getElementById(divId);
  messageDiv.style.display = "block";
  messageDiv.innerHTML = message;
  messageDiv.style.opacity = 1;
  setTimeout(function () {
    messageDiv.style.opacity = 0;
  }, 5000);
}

// Event listener for form submission
const rescue = document.getElementById('rsubmit');
rescue.addEventListener('click', (event) => {
  event.preventDefault();

  const resname = document.getElementById('rname').value;
  const resaddress = document.getElementById('raddress').value;
  const rescontact = document.getElementById('rcontact').value;

  console.log("Rescue Name: ", resname);
  console.log("Rescue Address: ", resaddress);
  console.log("Rescue Contact: ", rescontact);

  // Validate form fields
  if (!resname || !resaddress || !rescontact) {
    showMessage('Please fill in all fields', 'rescueMessage');
    return;
  }

  const db = getFirestore();

  // Rescue user data
  const ruserData = {
    name: resname,
    address: resaddress,
    contact: rescontact,
    timestamp: new Date()
  };

  console.log("Attempting to write to Firestore...");

  // Create a new document in Firestore with a unique ID
  const docRef = doc(db, "rusers", new Date().getTime().toString());

  // Set the document in Firestore
  setDoc(docRef, ruserData)
  .then(() => {
    showMessage('Request Submitted Successfully', 'rescueMessage');
    console.log("Data successfully written to Firestore.");

    // Reload the page after showing the success message
    setTimeout(() => {
      window.location.reload(); // Reloads the current page
    }, 1000); // Wait for 2 seconds before reloading the page
  })
  .catch((error) => {
    console.error("Error writing document: ", error);
    showMessage('Error submitting request. Try again later.', 'rescueMessage');
  });

});
