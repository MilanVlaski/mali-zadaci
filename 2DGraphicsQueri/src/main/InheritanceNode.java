package main;

import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Font;
import java.awt.GradientPaint;
import java.awt.Graphics;
import java.awt.Graphics2D;

public class InheritanceNode extends Entity{
	
	private String name;
	private int x;
	private int y;
	private static int objectCount = 1;
	private int centerX;
	private int centerY;
	private static int width = 32;
	private static int height = 32;
	
	
	public InheritanceNode(int x, int y){
		super(x, y);
		this.name = "Inheritance node" + objectCount;
		InheritanceNode.objectCount++;
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
		g2d.setPaint(new GradientPaint(x,y, new Color(178, 237, 226), x + width, y + height, new Color(178, 237, 210)));
		g2d.fillArc(x, y, width, height, 0, 180);
		
		g2d.setStroke(bs1);
		g2d.setColor(new Color(86, 50, 120));
		g2d.drawArc(x, y, width, height, 0, 180);
		g2d.drawLine(x, y + height/2, x + width, y + height/2);
	}
}
