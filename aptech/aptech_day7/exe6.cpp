#include <stdio.h>

int main(){
  int id, price, quantity;
  printf("Input id: \n");
  scanf("%d", &id);
  printf("Input price: \n");
  scanf("%d", &price);
  printf("Input quantity: \n");
  scanf("%d", &quantity);

  printf("%15s%15s%15s%15s\n" ,"id"," price","quantity","total");
  printf("%15d%15d%15d%15d\n", id, price, quantity, price*quantity);
} 
