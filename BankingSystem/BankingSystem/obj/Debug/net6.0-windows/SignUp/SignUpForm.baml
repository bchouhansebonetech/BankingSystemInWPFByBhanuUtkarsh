   M S B A M L   `   `   `  ����H  DBankingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BankingSystem.SignUpBankingSystem.SignUp  5   	   %    BankingSystem.SignUp.SignUpForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:BankingSystem.SignUp     5   	     � Title$  
SignUpForm��5   	   $	��500��6   $	��850��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ txtBlockTitle��5
      $��Center=�6+   $��0,10,0,0q�6H   $
��Wrap=�6Z   $��Sign-Up��6n   $	��Top=�6}   $��30(�6�   $
��Bold"�6�   �� 5   
   -   5        $ txtBlockFirstName��5      $
��Left=�6/   $��
264,60,0,0q�6J   $
��Wrap=�6^   $��First Name:��6r   $	��Top=�6�   $��20(�6�   $��SemiBold"�6�   �� 5   
   -   5        $ txtBlockLastName��5      $
��Left=�6.   $��266,100,0,0q�6I   $
��Wrap=�6^   $��
Last Name:��6r   $	��Top=�6�   $��20(�6�   $��SemiBold"�6�   �� 5   
   -   5        $ txtBlockUserName��5      $
��Left=�6.   $��261,140,0,0q�6I   $
��Wrap=�6^   $��
User Name:��6r   $	��Top=�6�   $��20(�6�   $��SemiBold"�6�   �� 5   
   -   5        $ txtBlockEMail��5      $
��Left=�6+   $��311,180,0,0q�6F   $
��Wrap=�6[   $��EMail:��6o   $	��Top=�6}   $��20(�6�   $��SemiBold"�6�   �� 5   
   -   5        $ txtBlockCity��5      $
��Left=�6*   $��325,220,0,0q�6E   $
��Wrap=�6Z   $��City:��6n   $	��Top=�6{   $��20(�6�   $��SemiBold"�6�   �� 5   
   -   5        $ txtBlockPincode��5      $
��Left=�6-   $��289,260,0,0q�6H   $
��Wrap=�6]   $��Pincode:��6q   $	��Top=�6�   $��20(�6�   $��SemiBold"�6�   �� 5   
   -   5        $ txtBlockPassword1��5      $
��Left=�6/   $��276,300,0,0q�6J   $
��Wrap=�6_   $��	Password:��6s   $	��Top=�6�   $��20(�6�   $��SemiBold"�6�   �� 5   
   -	   5        $ txtBlockPassword2��5      $
��Left=�6/   $��200,340,0,0q�6J   $
��Wrap=�6_   $��Confirm Password:��6s   $	��Top=�6�   $��20(�6�   $��SemiBold"�6�   �� 5   
   -
   5         ��Name$ txtFirstName��5      $
��Left=�6(   $��
400,60,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��200��6�   $��20(�6�   �� 5   
   -   5        $ txtLastName��5      $
��Left=�6'   $��400,100,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��200��6�   $��20(�6�   �� 5   
   -   5        $ txtUserName��5      $
��Left=�6'   $��400,140,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��200��6�   $��20(�6�   �� 5   
   -   5        $ txtEMail��5      $
��Left=�6$   $��400,180,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��200��6�   $��20(�6�   �� 5   
   -   5        $ txtCity��5      $
��Left=�6#   $��400,220,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��200��6   $��20(�6�   �� 5   
   -   5        $ 
txtPincode��5      $
��Left=�6&   $��400,260,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��200��6�   $��20(�6�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��400,300,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��200��6�   $��20(�6�   �� 5   
   -   5        $ txtConfirmPassword��5      $
��Left=�6.   $��400,340,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��200��6�   $��20(�6�   �� 5   
   -   5         ��Name$ 	btnSubmit��5      $��Submit��6$   $��Center=�65   $��	0,377,0,0q�6R   $	��Top=�6e   $��36(�6}   $��SemiBold"�6�   $	��2.5q�6�   ���	#FF3694C9
���������6�   Z�  � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5       " ��6   .�5!      ��  �@��CornerRadius$ 10��65   5"      5#      5$      5%      5&      