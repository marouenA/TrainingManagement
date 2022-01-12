import 'package:flutter/material.dart';
import 'package:training_manager_app/shared/Menu_Bottom.dart';
import 'package:training_manager_app/shared/Menu_Drawer.dart';
class ContactScreen extends StatelessWidget {
  const ContactScreen({ Key? key }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Contact Page')),
      drawer: MenuDrawer(),
      bottomNavigationBar: MenuBottom(),
      body: Center(child: Text('Contacts')),
      
    );
  }
}