// ignore_for_file: non_constant_identifier_names

class Student {
int ID=0;
String Nom="";
String Prenom="" ;
String Telephone="" ;
DateTime DateInscription =DateTime(1,1,1);
bool Payement =false ;

Student(this.ID,this.Nom,this.Prenom,this.Telephone,this.DateInscription,this.Payement);
Student.fromJson(Map<String , dynamic> studentMap){
  this.ID = studentMap['ID'];
  this.Nom = studentMap['Nom'];
  this.Prenom = studentMap['Prenom'];
  this.Telephone= studentMap['Telephone'];
  this.DateInscription = studentMap['DateInscription'];
  this.Payement = studentMap['Payment'];
}
}