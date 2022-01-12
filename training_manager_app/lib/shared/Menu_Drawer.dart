import 'package:flutter/material.dart';
import 'package:training_manager_app/screens/CoursesScreen.dart';
import 'package:training_manager_app/screens/allStudents_screen.dart';

import 'package:training_manager_app/screens/intro_screen.dart';
class MenuDrawer extends StatelessWidget {
  const MenuDrawer({ Key? key }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView(
        children: buildMenuItems(context))
    
      
    );
    }
    List<Widget> buildMenuItems(BuildContext context){
    final List<String> menuTitles=[
      'Home',
      'All',
      'Courses',
      'Students',
      'Teachers',
    ];

    List <Widget> menuItems=[];
    menuItems.add(
      DrawerHeader(
        decoration: BoxDecoration(color: Colors.blueGrey),
        child: Text('Training Center',style: TextStyle(color: Colors.white, fontSize: 28))));
       menuTitles.forEach((String element) {
         Widget screen = Container();
         menuItems.add(ListTile(title: Text( element,style : TextStyle(fontSize: 18)),onTap: (){
           switch(element){
             case 'Home' : 
             screen  =IntroScreen(); break;
              case 'All' : 
             screen  =AllStudentScreen(); break;
             case 'Courses' : 
              screen  =CoursesScreen(); break;
           }
           Navigator.of(context).pop();
           Navigator.of(context).push(
             MaterialPageRoute(builder: (context)=>screen)
           );
         }));
       
        });
        return menuItems;
  }
}