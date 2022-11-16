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
  printf("----------------------------\n");
}

//

void q2(){
  struct student
  {
    int id;
    char name[20];
    int age;
  };

  struct frequency 
  {
    int age;
    int count = 0;
  };

  int size;
  printf("Input size: \n");
  scanf("%d", &size);
  struct student students[size];
  struct frequency frequencies[size];

  for (int i = 0; i < size; i++) {
    printf("Input std[%d]\n", i);
    printf("Input id:\n");
    scanf("%d", &students[i].id);
    printf("Input name: \n");
    fflush(stdin);
    gets(students[i].name);
    printf("Input age: \n");
    scanf("%d", &students[i].age);
  }

  for (int i = 0; i < size; i++) {
    struct student std = students[i];
    bool found = false;

    for (int j = 0; j < size ; j++) {
      if (frequencies[j].age == std.age) {
        found = true;
        frequencies[j].count += 1;
      }
    }

    if (!found) {
      frequencies[i].age = students[i].age;
      frequencies[i].count = 1;
    }
  }
  
  struct frequency max = frequencies[0];
  for (int k = 0; k < size; k++) {
    struct frequency tmp = frequencies[k];

    if (max.count < tmp.count) {
      max = tmp;
    }
  }

  printf("Result: Age: %d has frequency: %d \n", max.age, max.count);
  printf("--------------------------\n");
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
        q2();
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
