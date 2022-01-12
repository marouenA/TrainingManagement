import 'package:training_manager_app/screens/contact_screen.dart';
import 'package:training_manager_app/screens/intro_screen.dart';

import '../shared/menu_drawer.dart';

import 'package:flutter/material.dart';

 void main(List<String> args) {
  runApp(TrainingCenterApp());
}

class TrainingCenterApp extends StatelessWidget {
  @override
  Widget build(BuildContext context){
    return MaterialApp( 
    theme: ThemeData(primarySwatch: Colors.blueGrey),
    routes: {
      '/':(context)=>IntroScreen(),
      '/contact':(context)=>ContactScreen()
    },
    initialRoute: '/',
    );
  }
}