   M S B A M L   `   `   `  ����F  BContactsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ContactsAppContactsApp  5   	   "    ContactsApp.NewContactWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ContactsApp     5   	     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$ NewContactWindow��5
   	   $	��200��6"   $	��300��6/   .��5      �  � RowDefinitions 5   
   �� 5      $
��163* �6   �� 5      $	��37* �6   .+�5   
   �� -   5         ��Name$ CloseButton��5      $��x��5      $��5(�5      $��291,0,0,153q�5      
���  ��
���  ��5      �� 5   
   $��10,10,10,10q�6   $��2��6*   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ Label��5      $��	0,0,3.6,5q�5      $��Name:��5      $��15(�5      �� 5      -   5         ��Name$ NameBox��5      $��20��5       $	��224��6"   $�� ��6.   5!      �� 5"      $ 
Horizontal=�6   .+�5#      �� $��	0,0,7.6,5q�5$      $��Email:��5%      $��15(�5&      �� 5(      -   5        $ EmailBox��5(      $��20��5)      $	��224��6&   $�� ��62   5*      �� 5+      $ 
Horizontal=�6   .+�5,      �� $��0,0,0,5q�5-      $��Phone:��5.      $��15(�5/      �� 51      -   5        $ PhoneBox��51      $��20��52      $	��224��6&   $�� ��62   53      �� 55      -   5        $
 Save��55      $
��Save��56      $��0,0,0,5q�58      $��20��59      5:      5;      5<      