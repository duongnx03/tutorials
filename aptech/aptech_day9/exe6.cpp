#include <stdio.h>

//sap xep price tang dan

int main(){
  struct foodStruct
  {
    char name[20];
    int price;
  };

  struct foodStruct foods[100];
  int size;

  printf("Input size: ");
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input foods[%d]\n" , i);
    printf("Input name: \n");
    fflush(stdin);
    gets(foods[i].name);
    printf("Input price: \n");
    scanf("%d", &foods[i].price);
    printf("--------------------\n");
    
  }

  struct foodStruct foodsTemp;
  for (int i = 0; i < size; i++) {
    for (int j = i+1; j < size; j++) {
      if (foods[j].price > foods[i].price) {
        foodsTemp = foods[i];
        foods[i] = foods[j];
        foods[j] = foodsTemp;
      }
    }
  }

  printf("Result cua bai toan la:\n");
  for (int i = 0; i < size; i++) {
    printf("-------------------\n");
    printf("Foods[%d]\n", i);
    printf("Name: %s\n", foods[i].name);
    printf("Price: %d\n", foods[i].price);
  }
}
