import 'package:flutter/material.dart';
import 'package:training_manager_app/shared/Menu_Bottom.dart';
import 'package:training_manager_app/shared/Menu_Drawer.dart';
class IntroScreen extends StatelessWidget {
  const IntroScreen({ Key? key }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text('Training Center')),
      drawer: MenuDrawer(),
      bottomNavigationBar: MenuBottom(),
      body: Container(
        // ignore: prefer_const_constructors
        decoration: BoxDecoration(
          image: DecorationImage(image: AssetImage('assets/home.jpg'),
          fit: BoxFit.cover
        )),
        child:  Center(
          child : Container(
            padding: EdgeInsets.all(24),
            
            decoration: BoxDecoration(
              borderRadius: BorderRadius.all(Radius.circular(20)),
            color: Colors.white70),

          
          child: Text('Welcome to IIT Training Center',style: TextStyle(fontSize: 22),)),
        ),
      ),
    
      
    );
  }
}

