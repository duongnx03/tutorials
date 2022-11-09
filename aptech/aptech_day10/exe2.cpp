#include <stdio.h>

void menu(){
  printf("**********************\n");
  printf("1.Question1 1         \n");
  printf("2.Question1 2         \n");
  printf("3.Exit                \n");
  printf("**********************\n");
}

void question1(){
  int num;
  printf("Input num: \n");
  scanf("%d", &num);
  for (int i = 1; i <= num; i++) {
    if (i % 3 == 0) {
      printf("%d ", i);
    }
  }
  printf("\n");
}

void question2(){
  struct company
  {
    char name[20];
    int profit;
    char location[20];
  };

  struct company cty[100];

  int size;
  printf("Input size: \n");
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input cty[%d]: \n", i);
    printf("Input name: \n");
    fflush(stdin);
    gets(cty[i].name);
    printf("Input profit: \n");
    scanf("%d", &cty[i].profit);
    printf("Input location: \n");
    fflush(stdin);
    gets(cty[i].location);
  }

  struct company tmp;
  for (int i = 0; i < size; i++) {
    for (int j = i+1; j < size; j++) {
      if (cty[j].profit > cty[i].profit) {
        tmp = cty[i];
        cty[i] = cty[j];
        cty[j] = tmp;
      }
    }
  }
  for (int i = 0; i < size; i++) {
    printf("________________\n");
    printf("cty[%d]\n", i);
    printf("Name: %s\n", cty[i].name);
    printf("Profit: : %d\n", cty[i].profit);
    printf("Locatio: %s\n", cty[i].location);
  }
}

int main(){
  int option;
  do
  {
    menu();
    printf("Input your option: \n");
    scanf("%d", &option);
    switch (option) {
      case 1:
        printf("Question1\n");
        question1();
        break;
      case 2:
        printf("Question2\n");
        question2();
        break;
      case 3:
        printf("Exit\n");
        break;
      default:
        printf("Choose 1 - 3\n");
        break;
    }
  } while(option != 3);
}

