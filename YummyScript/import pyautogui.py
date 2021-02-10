import pyautogui, keyboard,sys

speed = 0.25
def AddYummyApp():
    pyautogui.moveTo(1210,400,duration= speed + 0.14) 
    pyautogui.click(1210,400)
    pyautogui.moveTo(1410,650,duration= speed)  
    pyautogui.moveTo(1160,650,duration= speed- 0.25)   
    pyautogui.moveTo(1160,700,duration= speed - 0.99) 
    pyautogui.click(1160,700)
    pyautogui.moveTo(710,430,duration=speed - 0.08)   
    pyautogui.click(710, 430)
    
while True:    
    try:
        if keyboard.is_pressed("q"):
            sys.exit
            break
    except:
        break
    AddYummyApp()