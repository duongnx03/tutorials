//
//  main.m
//  exe1
//
//  Created by mac on 10/21/22.
//

#import <Foundation/Foundation.h>

#include <stdio.h>

int main(){
    int a;
    
    printf("input a: ");
    scanf("%d", &a);
    
    if(a % 4 == 0){
        printf("%d la nam nhuan", a);
    }else{
        printf("%d khong phai nam nhuan", a);
    }
}
