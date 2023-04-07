package main;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;

import javax.swing.JPanel;

public class MyPanel extends JPanel{

	private Diagram diagram;
	
	public MyPanel(Diagram diagram) {
		
		this.diagram = diagram;
		
		setPreferredSize(new Dimension(1000, 1000));
		setBackground(new Color(255, 255, 255));
		
		setVisible(true);
	}

	
	@Override
	public void paint(Graphics g) {
		super.paint(g);	
		Graphics2D g2d = (Graphics2D) g;
		diagram.drawDiagram(g2d);
	}
}
