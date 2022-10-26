#include <stdio.h>

int main(){
  int i, j, width, height;

  printf("Input width: \n");
  scanf("%d", &width);
  printf("Input height: \n");
  scanf("%d", &height);

  for ( i = 0; i < height; i++) {
    for ( j = 0; j < width; j++) {
      printf("*");
    }printf("\n");
  }
}
