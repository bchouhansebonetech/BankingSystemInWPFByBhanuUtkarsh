   M S B A M L   `   `   `  ����H  DBankingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BankingSystem.TransactionBankingSystem.Transaction  5   	   /    )BankingSystem.Transaction.TransactionForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:BankingSystem.Transaction     5   	     � Title$  TransactionForm��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5   
   �� -   5         ��Name$ myList��5      $��20, 100, 20, 70q�6#    �� View 5      �� 5      .P�5      �� $��TransactionID��6%    �� Width$	 145��6k    �� DisplayMemberBinding 6<   �� *TransactionID+6y   �� 5      $��Ammount��6%   $	 145��6_    66   �� *	Ammount+6m   �� 5      $��FromBank��6%   $	 145��6a    67   �� *
FromBank+6o   �� 5      $��ToBank��6%   $	 145��6]    65   �� *ToBank+6k   �� 5      $��CreditOrDeposite��6%   $	 145��6q    6?   �� *CreditOrDeposite+6   5      5      �� 5   
   $��Center=�6   $��0,22,0,0q�61   $
��Wrap=�6C   $��Transaction History��6W   $	��Top=�6r   $��24(�6�   $��SemiBold"�6�   �� 5   
   $
��Left=�6   $��
682,60,0,0q�6/   $
��Wrap=�6C   $��	User Name��6W   $	��Top=�6h   $��16(�6�   $��SemiBold"�6�   �� 5   
   -   5        $��
Send Money��5      $��Center=�6&   $��	0,370,0,0q�6C   $	��Top=�6V   $��18(�6n   6|   �� 5   
   -   5        $��	ComboBox1��5   &   $��	25,60,0,0q�6   $
��Left=�67   $	��Top=�6R   $	��150��6j   $��25��6v   .@�5       �� -   5        $
��both��5       $
��Both��6'   68   �� 5!      -   5        $��credit��5!      $��Credit��6)   6<   �� 5"      -   5        $��deposite��5"      $��Deposite��6+   6@   5#      5$      5%      