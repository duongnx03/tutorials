#include <stdio.h>

void menu(){
  printf("*****************\n");
  printf("* 1.Q1          *\n");
  printf("* 2.Q2          *\n");
  printf("* 3.Exit        *\n");
  printf("*****************\n");
}

void q1(){
  int size, num[100], cnt3 = 0, cnt4 = 0;

  printf("Input size: \n");
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input num[%d]\n", i);
    scanf("%d", &num[i]);
  }
  for (int i = 0; i < size; i++) {
    if (num[i] % 3 == 0) {
      cnt3++;
    }if (num[i] % 4 == 0) {
      cnt4++;
    }
  }printf("Tong so cac so chia het cho 3 la: %d\n", cnt3);
  printf("Tong so cac so chia het cho 4 la: %d\n", cnt4);
}

//

void q2(){
  struct student
  {
    int id;
    char name[20];
    int age;
  };

  int size;
  struct student std[100];
  printf("Input size: \n");
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input std[%d]\n", i);
    printf("Input id:\n");
    scanf("%d", &std[i].id);
    printf("Input name: \n");
    fflush(stdin);
    gets(std[i].name);
    printf("Input age; \n");
    scanf("%d", &std[i].age);
  }

  for (int i = 0; i < size; i++) {
    if (std[i].age == ) {
      
    }
  }

}



int main(){
  int option;
  do
  {
    menu();
    printf("Input your option: \n");
    scanf("%d", &option);
    printf("----------\n");

    switch (option) {
      case 1:
        q1();
        printf("Question 1: \n");
        break;
      case 2:
        printf("Question 2: \n");
        break;
      case 3: 
        printf("Exit\n");
        break;
      default:
        printf("Please choose 1-3\n");
        break;
    }
  } while(option != 3);

}
