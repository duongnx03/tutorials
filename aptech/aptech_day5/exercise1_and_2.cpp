#include <stdio.h>

int main(){
  int size = 0, min, max;
  int num[10000];

  printf("Input size: ");
  scanf("%d", &size);


  for ( int i = 0; i < size; i++){
    printf("Input value of the element [%d]: ", i);
    scanf("%d", &num[i]);
  }

  for (int i = 0; i < size; i++){
    printf("Element [%d] has a value of: %d\n", i, num[i]);
  } 

  min = max = num[1];
  for ( int i = 0; i < size; i++){
    if (num[i] < min){
      min = num[i];
    }  

    if (num[i] > max){
      max = num[i];
    }
  }
  printf("-The smallest value in the array is: %d  ",min);
  printf("\n-The largest value in the array is: %d", max);
  
  printf("\n======>  Perfect!");
}  
