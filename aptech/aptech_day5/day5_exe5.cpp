#include <stdio.h>

int main(){
  int num[5];

  for (int i = 0; i < 5; i++) {
    printf("Input num[%d]: \n", i);
    scanf("%d", &num[i]);
  }
  for (int i = 0; i < 5; i++) {
    printf("Num [%d]: %d\n", i, num[i]);
  }
}
