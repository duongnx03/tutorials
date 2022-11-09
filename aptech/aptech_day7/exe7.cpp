#include <stdio.h>

int main(){
  int size = 0;
  int num[100];

  printf("Input size: \n"); 
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input value[%d]: \n", i);
    scanf("%d", &num[i]);
  }
  printf("Even number: ");
  for (int i = 0; i < size; i++) {
    if (num[i] % 2 == 0) {
      printf("%d ", num[i]);
    }
  }

  printf("\nSo chia het cho 3: ");
  for (int i = 0; i < size; i++) {
    if (num[i] % 2 == 0 && num[i] % 3 == 0) {
      printf("%d ", num[i]);
    }
  }
}


