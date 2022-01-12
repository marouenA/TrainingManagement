import 'package:flutter/material.dart';
import 'package:training_manager_app/shared/Menu_Drawer.dart';
class CoursesScreen extends StatelessWidget {
  const CoursesScreen({ Key? key }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar : AppBar(title: Text('Courses')),
      drawer: MenuDrawer(),
      body: Center(child: Text('Courses')),
      
    );
  }
}