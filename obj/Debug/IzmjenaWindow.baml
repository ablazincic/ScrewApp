   M S B A M L   `   `   `  ����C  ?ScrewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ScrewAppScrewApp  5   	       ScrewApp.IzmjenaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ScrewApp     5   	     � Title$  IzmjenaWindow��5   	   $	��450��6   $	��800��6,    � Icon$ /icon/screw.png��68    � WindowStartupLocation$ CenterScreen=�6O   .��5	      � ���	#FF212529.+�5
   
   �� $!��Copyright ©ablazincic 2024��6   $��Center=�65   $��	0,373,0,0q�6R   $	��Top=�6e   $��10(�6}   $��SF Pro Display)�6�   
�������6�   �� 5   
   -   5         ��Name$ btnDodaj��5      $��Dodaj��6#   $
��Left=�63   $��160,124,0,0q�6N   $	��Top=�6c   $��80��6{   $��30��6�   $��15(�6�   $
��Bold"�6�   $��SF Pro Display)�6�   6�   �� 5   
   -   5         ��Name$ txtNaziv��5      $
��Left=�6$   $��
134,80,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��130��6   $��24��6�   $��SF Pro Display)�6�   $��14(�6�   �� 5   
   $��Naziv vijka��6   $
��Left=�6&   $��	37,80,0,0q�6A   $	��Top=�6T   $��16(�6l   $��SF Pro Display)�6z   
�������$
��Bold"�6�   � 5   
   $��422,20,36,0q�6   $	��Top=�6$   $��30��6<   ���	#FF4A4F54 � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��ID��6   
�������$
��Bold"�65   $
��Left=�6G   $��SF Pro Display)�6b   $��5,4,0,-4q�6~   �� 5      $��Naziv��6   
�������$
��Bold"�68   $
��Left=�6J   $��SF Pro Display)�6e   $��	30,4,0,-4q�6�   5      �� 5   
   -   5         ��Name$ listBoxScrew��5      $��422,42,36,153q�6S   ���	#FF3A3F42 J� RenderTransformOrigin$ 0.5,0.5&�6�   $��SF Pro Display)�6�   $��16(�6�   
�������z�5      V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$	 0Q�6&   T� 5      5      5       �� 5!   
   -   5        $ 
btnIzbrisi��5!      $��Izbriši��6%   $
��Left=�67   $��623,300,0,0q�6R   $	��Top=�6g   $��80��6   $��30��6�   $��SF Pro Display)�6�   $
��Bold"�6�   $��15(�6�   6�   �� 5"   
   -   5        $ btnAzuriraj1��5"      $��	Ažuriraj��6'   $
��Left=�6:   $��479,300,0,0q�6U   $	��Top=�6j   $��80��6�   $��30��6�   $��SF Pro Display)�6�   $
��Bold"�6�   $��15(�6�   6�   �� 5#   
   -   5        
 ��Name$
 
imgIzmjeni��5#      $
��Left=�6$   $	��130��6?   $��134,217,0,0q�6L   $	��Top=�6a   $	��133��6y   �� 5$   
   -   5        $ btnSlika��5$      $��Dodaj Sliku!��6#   $
��Left=�6:   $��160,172,0,0q�6U   $	��Top=�6j   $��30��6�   $��80��6�   $
��Bold"�6�   $��SF Pro Display)�6�   6�   5%      5&      