#include <stdio.h>  
int main(){  
   FILE *f;  
   f = fopen("file.txt", "w");//mo file 
   fprintf(f, "Programing\n"); //nhap du lieu
   fclose(f);//dong file 
}  
