package main;

import java.awt.AlphaComposite;
import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Font;
import java.awt.FontMetrics;
import java.awt.GradientPaint;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.geom.Line2D;
import java.awt.geom.Point2D;

import javax.swing.JPanel;

public class Entity extends JPanel{
	
	private String name;
	private int x;
	private int y;
	private static int objectCount = 1;
	private int centerX;
	private int centerY;
	private static int width = 120;
	private static int height = 90;
	
	
	public Entity(int x, int y) {
		this.name = "Entity" + objectCount;
		Entity.objectCount++;
		this.x = x;
		this.y = y;
		this.centerX = x + width/2;
		this.centerY = y + height/2; 
	}
	
	public int getCenterX() {
		return centerX;
	}

	public int getCenterY() {
		return centerY;
	}

	public void doDrawing(Graphics g) {
		
		Graphics2D g2d = (Graphics2D) g;
		
		BasicStroke bs1 = new BasicStroke(2, BasicStroke.CAP_SQUARE, BasicStroke.JOIN_MITER, 5);
		g2d.setPaint(new GradientPaint(x,y, new Color(178, 237, 194),x + width, y + height, new Color(161, 201, 196)));
		g2d.fillRect(x, y, width, height);

		g2d.setStroke(bs1);
		g2d.setColor(new Color(60, 120, 50));
		g2d.drawRect(x, y, width, height);
		g2d.drawLine(x, y + height/3, x + width, y + height/3);
		g2d.drawLine(x, y + 2*height/3, x + width, y + 2*height/3);
		
		g2d.setColor(new Color(40, 100, 50));
		g2d.setFont(new Font("Helvetica", Font.PLAIN, 16));
		int nameOffset = g2d.getFontMetrics().charsWidth(name.toCharArray(), 0, name.length()/2);
		g2d.drawString(name, centerX - nameOffset, centerY - height/3 + g2d.getFontMetrics().getDescent());
		
	}
}
