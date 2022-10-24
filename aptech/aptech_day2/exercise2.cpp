#include <iostream>

int main(){
  int mark;
  printf("Input mark: \n");
  scanf("%d", &mark);

  if(mark <= 100 && mark >= 90){
    printf("So Good\n");
  }
  if(mark <= 90 && mark >= 75){
    printf("Good\n");
  }
  if(mark <= 75 && mark >= 40){
    printf("bad\n");
  }
  if(mark <= 40){
    printf("So bad\n");
  }
}
