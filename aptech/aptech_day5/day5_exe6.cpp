#include <stdio.h>

int main(){
  int size = 0;
  int num[100];
  printf("Input size: \n");
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input num[%d]: \n", i);
    scanf("%d", &num[i]);
  }
  for (int i = 0; i < size; i++) {
    printf("Num [%d]: %d\n", i, num[i]);
  }
}
