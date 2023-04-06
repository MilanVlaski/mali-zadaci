package main;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JProgressBar;
import javax.swing.Timer;

public class MyFrame extends JFrame implements ActionListener{

	private static final long serialVersionUID = 1L;
	JProgressBar bar = new JProgressBar(0, 500);
	JButton btn = new JButton();
	private Timer timer;

	public MyFrame() {

		btn.setBackground(Color.GREEN);
		btn.addActionListener(this);
		btn.setFocusable(false);
		btn.setFont(new Font("Comic Sansa", Font.BOLD, 25));

		bar.setValue(500);
		bar.setBounds(0, 0, 500, 50);
		bar.setStringPainted(true);
		bar.setFont(new Font("Consolas", Font.BOLD, 25));
		bar.setForeground(Color.yellow);
		bar.setForeground(Color.RED);
		bar.setBorderPainted(false);
		bar.setBackground(Color.BLACK);

		this.setLayout(new BorderLayout());
		this.add(bar, BorderLayout.NORTH);
		this.add(btn, BorderLayout.CENTER);
		this.setSize(500, 500);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setVisible(true);

	}

	@Override
	public void actionPerformed(ActionEvent e) {

		if (e.getSource() == btn) {
			ouch(btn);
		}
	}

	private void ouch(JButton btn) {

		ActionListener slusaTajmer = new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				btn.setBackground(Color.GREEN);
				btn.setText(null);
			}
		};
		bar.setValue(bar.getValue() - 75);
		if (bar.getValue() != 0) {
			btn.setBackground(Color.RED);
			btn.setText("Ouch >.<");

			timer = new Timer(300, slusaTajmer);
			timer.setRepeats(false);
			timer.start();
		} else {
			btn.setBackground(Color.LIGHT_GRAY);
			btn.setFont(new Font("Times New Roman", Font.PLAIN, 25));
			btn.setText("RIP X[");
		}
	}
}
