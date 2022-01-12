import 'package:http/http.dart' as http;
import 'package:training_manager_app/data/Student.dart';
import 'dart:convert';

class HttpHelper {
  final String authority='localhost:41147';
  final String path='Etudiant';

  Future<List<Student>> getStudents() async {
    Map<String,dynamic> parameters={};
    Uri uri=Uri.https(authority, path);
    http.Response result = await http.get(uri);
    List<dynamic> data = json.decode(result.body);
    List<Student> students = [];
    data.forEach((element) {
      students.add(Student.fromJson(element));
    });
    return students;
  }
}