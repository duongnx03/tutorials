#include <stdio.h>

int main(){
  int size = 0, sum = 0;
  int num[100];
  
  printf("Input size: \n");
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input num[%d]: \n", i);
    scanf("%d", &num[i]);
  }
  for (int i = 0; i < size; i++) {
    sum += num[i];
  }
  printf("Tong: %d\n", sum);
  printf("TB cong: %d \n", sum/size);
}
