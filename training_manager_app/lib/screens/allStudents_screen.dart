import 'package:flutter/material.dart';
import 'package:training_manager_app/data/Student.dart';
import '../data/http_helper.dart';

class AllStudentScreen extends StatefulWidget {
  const AllStudentScreen({ Key? key }) : super(key: key);

  @override
  _AllStudentScreenState createState() => _AllStudentScreenState();
}

class _AllStudentScreenState extends State<AllStudentScreen> {
  List<Student> result= [Student(0,'','','',DateTime(1,1,1),false)];
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title:Text('List Of Students')),
      body: Column(children: [
        ElevatedButton(
          child: Text('Get List'),
          onPressed: getData),
          DataTable(
            columns: const <DataColumn>[
              DataColumn(label: Text('Nom',style: TextStyle(fontStyle:FontStyle.italic ),),),
              DataColumn(label: Text('Prenom',style: TextStyle(fontStyle:FontStyle.italic ),),),
              DataColumn(label: Text('Telephone',style: TextStyle(fontStyle:FontStyle.italic ),),),
              DataColumn(label: Text('Date',style: TextStyle(fontStyle:FontStyle.italic ),),),
              DataColumn(label: Text('Payement',style: TextStyle(fontStyle:FontStyle.italic ),),),
              
            ], 
            rows: result
            .map((e) => DataRow(
              cells: <DataCell>[
                DataCell(Text(e.Nom)),
                DataCell(Text(e.Prenom)),
                DataCell(Text(e.Telephone)),
                DataCell(Text(e.Telephone)),
               DataCell(Text(e.Telephone)),

              ],
            )).
            toList()),
      ],
      ),
      
    );
  }
  Future getData() async{
    HttpHelper helper =HttpHelper();
    result = await helper.getStudents();
    setState(() {
      
    });
  }
}