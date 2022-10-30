#include <stdio.h>

int main(){
  int size = 0;
  float abc[10];

  printf("Input size: \n");
  scanf("%d", &size);
  
  for (int i = 0; i < size; i++) {
    printf("Input num[%d]: \n", i);
    scanf("%f", &abc[i]);
  }
  for (int i = 0; i < size; i++) {
    if (abc[i] < 0) {
      printf("abc[%d]: %f\n", i, abc[i]);
    }
    
  }
}
