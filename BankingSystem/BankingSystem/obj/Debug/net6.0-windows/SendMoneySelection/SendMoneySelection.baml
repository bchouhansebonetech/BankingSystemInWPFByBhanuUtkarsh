   M S B A M L   `   `   `  ����H  DBankingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:BankingSystem.SendMoneySelection BankingSystem.SendMoneySelection  5   	   9    3BankingSystem.SendMoneySelection.SendMoneySelection   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:BankingSystem.SendMoneySelection     5   	     � Title$  SendMoneySelection��5   	   $	��450��6$   $	��800��61   .��5	      � -   5         �Name$ SelectMoneyGriid��5	      ���	#FF67083C.+�5
   
   �� -   5         ��Name$ SelectionTextBlock��5
      $
��Left=�60   $��
258,10,0,0q�6K   $
��Wrap=�6_   $��Select To Pay��6s   $	��Top=�6�   $��56��6�   $	��231��6�   $��36(�6�   ���	#FFC1B9B9$
��Bold"�6�   �� 5   
   -   5         ��Name$ AddNewPayeeButton��5      $��Add new payee��6,   $
��Left=�6D   $��
621,45,0,0q�6_   $	��Top=�6s   $	��148��6�   ���	#FFC17C89$��18(�6�   $��28��6�   6�   �� 5   
   -   5         ��Name$ PayeeDetailListView��5      $��
10,92,10,0q�6Z   $	��332��6n   $	��Top=�6{   ���	#FFAD4B79$��18(�6�    �� SelectedIndex$ 1��6�   ��6�   ��  �� Mode$ OneWay=� �� View 5      �� 5      .P�5      �� $
��Name��6P    �� Width$	 200��6^   	 �� DisplayMemberBinding	 6%   �� *	payeeName+6l   �� 5      $��Account Number��6U   $	 200��6m   	 6%   �� *payeeAccountNo+6{   �� 5      $��Location��6O   $	 200��6a   	 6%   �� *
location+6o   �� 5      $	 200��6%   
 �� CellTemplate
 5      �� 5      .R�5   "   �� $ SendMoneyButton��6)   -   5        $��	Sendmoney��5   B   
������6n   5      .��5   7   >5      5      5      5      5      