   M S B A M L   `   `   `  ����H  DBankingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BankingSystem.LogInBankingSystem.LogIn  5   	   #    BankingSystem.LogIn.LogInForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BankingSystem.LogIn     5   	     � Title$  	LogInForm��5   	   $	��450��6   $	��800��6(   .��5	      � -   5         �Name$ 	LoginGrid��5	       J� RenderTransformOrigin$ 0.508,0.512&�6    � ColumnDefinitions 5
   
   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ White��6    � Offset$ 1Q�6-   5      .+�5   
   �� -   5         ��Name$ WelcomeTextBlock��5      $
��Left=�6.   $��
271,10,0,0q�6I   $
��Wrap=�6]   $��
Login here��6q   $	��Top=�6�   $��48(�6�   $
��Bold"�6�   $��64��6�   $	��239��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ 	#FFFFDE00��6#   $ 1Q�65   5      5      �� 5   
   -   5        	 ��Name$	 UserNameLabel��5      $��Username��6'   $
��Left=�6:   $��
31,165,0,0q�6U   $	��Top=�6i   $	��171��6�   $��20(�6�   $��Dubai)�6�   $
��Bold"�6�   $��Italic$�6�   $��2��6�   $��44��6�   �� 5   
   -   5        $	 passwordLabel��5      $��Password��6'   $
��Left=�6:   $��
31,230,0,0q�6U   $	��Top=�6i   $��20(�6�   $��Dubai)�6�   $
��Bold"�6�   $��Italic$�6�   $��2��6�   $��44��6�   $��91��6�   �� 5   
   -   5        
 ��Name$
 usernameTextBox��5      $
��Left=�6+   $��281,174,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��229��6�   $��28��6�   ���	#FFF8F4F4$��20(�6�   $��Dubai)�6�   $��2��6�   G� 5   
   -   5         G�Name$ PasswordBox��5      $
��Left=�6+   $��281,239,0,0q�6F   $	��Top=�6\   $	��229��6t   $ 1.115,3.376&�6�   $��28��6�   $��2��6�   ��6�   �� *
Background+ �� ElementName$ usernameTextBox��6�   �� 5   
   -   5         ��Name$ loginButton��5      $��Login��6&   $��Center=�66   $��	0,340,0,0q�6S   $	��Top=�6f   ���	#FFA3CF82$��26(�6�   $
��Bold"�6�   $��84��6�   $��Dubai)�6�   $��Italic$�6�   $��48��6�   $ 0.424,-0.365&�6�   6  �� 5    
   -   5        $ signupbutton��5       $��Signup��6'   $
��Left=�68   $��483,340,0,0q�6S   $	��Top=�6h   ���	#FFA3CF82$��26(�6�   $
��Bold"�6�   $��Italic$�6�   $��Dubai)�6�   $��48��6�   $��81��6�   6�   5"      5#      