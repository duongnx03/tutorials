#include <stdio.h>

int main(){
 // int num[10];

  //khai bao bien
  struct books
  { 
    char name[25]; 
    char author[20];
    int edn;
    float price;
  };

  //khai bao bien kieu struct
  struct books book1, book2;

  //truy cap den bien name cua bien book1
  book1.name;

  printf("Input name: \n");
  gets(book1.name );
  printf("%s\n", book1.name);

  printf("Input author: \n");
  gets(book1.author );
  printf("%s\n", book1.author);

  printf("Input edn: \n");
  scanf("%d", &book1.edn);
  printf("%d\n", book1.edn);

  printf("Input price: \n");
  scanf("%f", &book1.price);
  printf("%f\n", book1.price);


}
