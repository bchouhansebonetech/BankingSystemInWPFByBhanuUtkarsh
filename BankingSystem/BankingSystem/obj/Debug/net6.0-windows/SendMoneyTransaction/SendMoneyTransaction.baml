   M S B A M L   `   `   `  ����H  DBankingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:BankingSystem.SendMoneyTransaction"BankingSystem.SendMoneyTransaction  5   	   0    *BankingSystem.SendMoneyTransaction.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:BankingSystem.SendMoneyTransaction     5   	   -   5          �Name$  SendMoneyTransaction��5   	    � Title$ SendMoneyTransaction��5   	   $	��450��6&   $	��800��63   .��5	      � ���	#FFAA3E85 � ColumnDefinitions 5
   
   .+�5   
   �� -   5         ��Name$ SendMoneyTextBlock��5      $��Center=�60   $��0,10,0,0q�6M   $
��Wrap=�6_   $��
Send Money��6s   $	��Top=�6�   ���	#FFC7BEBE$��48(�6�    J� RenderTransformOrigin$ 0.429,0.216&�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ PayeeNameLabel��5      $��Name 
��6(   $
��Left=�6B   $��
81,141,0,0q�6]   $	��Top=�6q   $ 0.5,0.5&�6�   $��39��6�   $	��137��6�   $��24(�6�   ���	#FFF0E4E4z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.162Q�6&   T� 5      5      5      �� 5   
   $��Account Number��6   $
��Left=�6)   $��76,0,0,0q�6D   $��Center=�6V   ���	#FFF0E4E4$��24(�6�   �� 5   
   $��IFC code��6   $
��Left=�6#   $��
76,259,0,0q�6>   $	��Top=�6R   $��24(�6j   ���	#FFF0E4E46x   �� 5   
   $
��From��6   $
��Left=�6   $��
76,322,0,0q�6:   $	��Top=�6N   ���	#FFF0E4E4$��24(�6}   �� 5   
   -   5         ��Name$ NameTextBox��5      $
��Left=�6'   $��331,151,0,0q�6B    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��230��6�   $��25��6�   ���	#FFF0E4E4$��24(�6�   �� 5   
   -   5        $ AccountNumberTextBox��5      $
��Left=�60   $��	331,0,0,0q�6K   $
 Wrap=�6^   $��Center=�6r   $	��230��6�   $��25��6�   ���	#FFF0E4E4$��24(�6�   �� 5   
   -   5        $ 
IFCTextBox��5      $
��Left=�6&   $��331,267,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��230��6�   $��25��6�   $��20(�6�   ���	#FFF0E4E46�   �� 5   
   -   5        $ FromTextBox��5      $
��Left=�6'   $��331,330,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��230��6�   $��25��6�   $��20(�6�   ���	#FFF0E4E46�   �� 5   
   -   5        	 ��Name$	 TransactionButton��5      $��
Tranaction��6,   $
��Left=�6A   $��610,384,0,0q�6\   $	��Top=�6q   $��40��6�   $	��129��6�   ���	#FF790B5C���	#FFF1EEEE$��24(�6�   6�   �� 5    
   $��amount��6   $
��Left=�6!   $��
76,375,0,0q�6<   $	��Top=�6P   ���	#FFF1EEEE$��24(�6   �� 5!   
   -	   5        $ amountTextBox��5!      $
��Left=�6)   $��331,384,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��230��6�   $��20(�6�   $��24��6�   ���	#FFF1EEEE6�   5#      5$      