package main;

import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.geom.Line2D;

public class AssociativeLink extends Relationship{

	private String name;
	private static int relCount = 1;
	private int x1;
	private int y1;
	private int x2;
	private int y2;

	public AssociativeLink(int x1, int y1, int x2, int y2) {
		super(x1, y1, x2, y2);
		this.name = "ASSOCIATION_LINK_" + relCount;
		AssociativeLink.relCount++;
		this.x1 = x1;
		this.y1 = y1;
		this.x2 = x2;
		this.y2 = y2;
	}

	public void doDrawing(Graphics g) {
		
		Graphics2D g2d = (Graphics2D) g;
		BasicStroke bs1 = new BasicStroke(1.5f);
		
		g2d.setStroke(bs1);
		g2d.setColor(new Color(59, 168, 219));
		
		Line2D line = new Line2D.Double(x1, y1, x2, y2);
		
		g2d.draw(line);
		
		g2d.setColor(new Color(44, 118, 184));
		g2d.setFont(new Font("Consola", Font.PLAIN, 10));
		int nameOffset = g2d.getFontMetrics().charsWidth(name.toCharArray(), 0, name.length()/2);
		g2d.drawString(name, (x1 + x2)/2  - nameOffset, (y1 + y2)/2 + g2d.getFontMetrics().getAscent());
	}
}
