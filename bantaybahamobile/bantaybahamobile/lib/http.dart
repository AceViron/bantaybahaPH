import 'dart:async';
import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class MJPEGStreamWidget extends StatefulWidget {
  final String url;
  final double width;
  final double height;

  const MJPEGStreamWidget({super.key, 
    required this.url,
    this.width = 400,
    this.height = 300,
  });

  @override
  _MJPEGStreamWidgetState createState() => _MJPEGStreamWidgetState();
}

class _MJPEGStreamWidgetState extends State<MJPEGStreamWidget> {
  late StreamController<Uint8List> _streamController;

  @override
  void initState() {
    super.initState();
    _streamController = StreamController<Uint8List>();
    _startStream();
  }

  Future<void> _startStream() async {
    try {
      final response = await http.Client().send(http.Request('GET', Uri.parse(widget.url)));
      response.stream.listen((data) {
        _streamController.add(Uint8List.fromList(data));
      });
    } catch (e) {
      print('Error: $e');
    }
  }

  @override
  void dispose() {
    _streamController.close();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return StreamBuilder<Uint8List>(
      stream: _streamController.stream,
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const CircularProgressIndicator();
        } else if (snapshot.hasError) {
          return const Text("Error loading stream");
        } else if (snapshot.hasData) {
          return Image.memory(
            snapshot.data!,
            width: widget.width,
            height: widget.height,
            fit: BoxFit.cover,
          );
        } else {
          return const Text("No data");
        }
      },
    );
  }
}
