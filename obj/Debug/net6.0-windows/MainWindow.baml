   M S B A M L   `   `   `  ����H  DMidtermWinter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MidtermWinterMidtermWinter  5   	       MidtermWinter.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MidtermWinter     5   	     � Title$  Tenant Tracker��5   	   $	��450��6    $	��800��6-   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FFFFA0DD��6    � Offset$ 1Q�61   5      .+�5   
   �� ���	#FFEFC6EA$��295,55,261,33q�6(   .+�5      �� $��    First Name; ��6    �� Left$ 68��6/   
 �� Top$ 10��6@   $��27��6P   $	��110��6\   ���	#FF150000���	#FFFF3FC3$
��Bold"�6�   $��Century Gothic)�6�   $
��Left=�6�   $��Center=�6�   �� 5      $��    Last Name: ��6   $ 68��6.   $ 79��6?   $��27��6O   $	��110��6[   ���	#FF150000���	#FFFF3FC3$
��Bold"�6�   $��Century Gothic)�6�   $��Center=�6�   $	��Top=�6�   �� 5      $��   Monthly Payment��6   $ 56��61   $	 145��6B   $��27��6S   $	��133��6_   ���	#FF150000���	#FFFF3FC3$
��Bold"�6�   $��Century Gothic)�6�   $
��Left=�6�   $	��Top=�6�   �� 5      $��    Number of Bedrooms��6   $ 46��65   $	 210��6F   $��27��6W   $	��154��6c   ���	#FF150000���	#FFFF3FC3$
��Bold"�6�   $��Century Gothic)�6�   $
��Left=�6�   $	��Top=�6�   �� 5      -   5         ��Name$ txtFirstName��5      $ 40��6,    �� TextWrapping$
 Wrap=�6=   $ 42��6Q   $	��166��6a   $
��Left=�6m   $	��Top=�6�   $��28��6�   �� 5      -   5        $ txtLastName��5      $ 40��6+   $
 Wrap=�6<   $	 111��6P   $	��166��6a   $��28��6m   $��Center=�6y   $	��Top=�6�   �� 5      -   5        $ txtMontlhlyPayment��5      $ 40��62   $
 Wrap=�6C   $	 177��6W   $	��166��6h   $��28��6t   $��Center=�6�   $	��Top=�6�   �� 5      -   5        $ txtNumofBedrooms��5      $ 40��60   $
 Wrap=�6A   $	 237��6U   $	��166��6f   $��28��6r   $��Center=�6~   $	��Top=�6�   �� 5      -   5        	 ��Name$	 	btnRemove��5      $��Remove��6(   $ 57��69   $	 316��6J   $
��Left=�6[   $��Center=�6v   $	��132��6�   6�   �� 5      -   5        $	 btnAddUpdate��5      $��Add / Update Tenant��6+   $ 27��6I   $	 284��6Z   $
��Left=�6k   $��Center=�6�   $	��192��6�   6�   5      �� 5   
   $��557,10,10,201q�6   . �5      /� .T�5      J� .*�6   .*�5      �� -   5        
 ��Name$
 
runDisplay��5      5       5!      5"      �� 5#   
   $��557,292,13,12q�6   ��5$      �� 5%      $ 0.5,1&�6&   $ 0.5,0&�67   .��5&      � $ Black��6#   � 5'      $ 	#FF76FF1B��6#   $ 0.414Q�65   5(      .+�5*      �� $��PAYMENT��6   
�������$
��Left=�69   $	��Top=�6T   $	��108��6l   �� 5+      -   5        $ 
txtPayment��5+      $
 Wrap=�6*   $ 31��6>   $	��166��6N   $
��Left=�6Z   $	��Top=�6u   $��60��6�   $ 32��6�   �� 5,      -	   5        $��
Paid Fully��5,      $	 100��6*   $
��Left=�6;   $��Center=�6V   $��92��6q   6|   �� 5-      -
   5        $��Partially Paid��5-      $	 100��6.   $��92��6?   $
��Left=�6J   $��Center=�6e   $	 138��6�   6�   5.      �� 50   
   -   5         ��Name$ lbUnits��50      $��6,227,524,10q�6N   6d   �� 51   
   $��-2,10,517,209q�6   $��/MarkTag.jpg��6'   $
��Fill=�6=   53      54      