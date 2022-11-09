#include <stdio.h>

//nhap size va sort theo thu tu giam dan
int main(){
  int num[100];
  int size ;
  int tmp;

  printf("Input size: ");
  scanf("%d", &size);
  for (int i = 0; i < size; i++) {
    printf("Input value[%d]: \n", i);
    scanf("%d", &num[i]);
  }

  for (int i = 0; i < size; i++) {
    for (int j = i+1; j < size; j++) {
      if(num[j] > num[i]){
        tmp = num[i];
        num[i] = num[j];
        num[j] = tmp;
      }
    }
  }

  for (int i = 0; i < size; i++) {
    printf("%d/n", num[i]);
  }
}
