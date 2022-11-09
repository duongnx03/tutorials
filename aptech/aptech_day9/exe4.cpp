#include <stdio.h>
//nhap so sort theo thu tu tang dan

int main(){
  int num[7] , tmp;

  for (int i = 0; i < 7; i++) {
    printf("Input num [%d]", i);
    scanf("%d", &num[i]);
  }

  for (int i = 0; i < 7; i++) {
    for (int j = i+1; j < 7; j++) {
      if (num[j] < num[i]) {
        tmp  = num[i];
        num[i] = num[j];
        num[j] = tmp;
      }
    }
  }

  for (int i = 0; i < 7; i++) {
    printf("%d\n", num[i]);
  }
}
