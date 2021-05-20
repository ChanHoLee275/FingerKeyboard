# FingerKeyboard
project for biomedical engineering using MSP430

## FingerKeyboard Demo
MSP430과 연결이 되어 있는 센서로부터 신호를 받아드리기 전, 키보드 interrupt를 임의로 발생시켰을 때, 작동하는지 확인을 하기 위해 작성한 코드

## FingerKeyboard
MSP430과 연결을 시켜, strain sensor로 부터 값을 받아와 굽혀진 정도를 판단하여 입력인지 아닌지를 판단하여 입력에 맞추어 키보드 interrupt를 발생시키는 프로그램.
다양한 유저가 사용할 수 있게 유저를 등록할 때, 굽혀지는 정도에 따른 값을 받아드려 ON/OFF state를 결정할 threshold를 결정

SCI 통신을 활용하여 MSP430과 window program과 정보를 교환함.
