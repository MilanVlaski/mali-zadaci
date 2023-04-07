package main;

import java.awt.AlphaComposite;
import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Polygon;
import java.awt.Shape;
import java.awt.geom.AffineTransform;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Line2D;
import java.awt.geom.Point2D;

public class Relationship {
	
	private String name;
	private static int relCount = 1;
	private int x1;
	private int y1;
	private int x2;
	private int y2;

	public Relationship(int x1, int y1, int x2, int y2) {
		super();
		this.name = "RELATIONSHIP_" + relCount;
		Relationship.relCount++;
		this.x1 = x1;
		this.y1 = y1;
		this.x2 = x2;
		this.y2 = y2;
	}

	public void doDrawing(Graphics g) {
		
		Graphics2D g2d = (Graphics2D) g;
		AlphaComposite ac = AlphaComposite.getInstance(AlphaComposite.DST_ATOP);
		
		BasicStroke bs1 = new BasicStroke(1.5f);
		g2d.setStroke(bs1);
		g2d.setColor(new Color(59, 219, 203));
		
		Line2D line = new Line2D.Double(x1, y1, x2, y2);
		
		g2d.draw(line);
		
		g2d.setColor(new Color(14, 131, 136));
		g2d.setFont(new Font("Consola", Font.PLAIN, 10));
		int nameOffset = g2d.getFontMetrics().charsWidth(name.toCharArray(), 0, name.length()/2);
		g2d.drawString(name, (x1 + x2)/2  - nameOffset, (y1 + y2)/2 + g2d.getFontMetrics().getAscent());
	}
//		g2d.setFont(new Font("Consolas", Font.PLAIN, 16));
//		int nameOffset = g2d.getFontMetrics().charsWidth(name.toCharArray(), 0, name.length()/2);
//		g2d.translate((int)Math.abs(start.getX() - end.getX()), (int)Math.abs(start.getY() - end.getY()));
		
//		drawArrow(g2d, (int)end.getX(), (int)end.getY(), (int)end.getX(), (int)end.getY(), 10, 30);
//		tx = new AffineTransform();
//		Polygon arrowHead = new Polygon();  
//		arrowHead.addPoint( 0,5);
//		arrowHead.addPoint( -5, -5);
//		arrowHead.addPoint( 5,-5);
//		
//		drawArrowHead(g2d);
//	    static public void drawArrow(Graphics g, int x0, int y0, int x1,
//	            int y1, int headLength, int headAngle) {
//	        double offs = headAngle * Math.PI / 180.0;
//	        double angle = Math.atan2(y0 - y1, x0 - x1);
//	        int[] xs = { x1 + (int) (headLength * Math.cos(angle + offs)), x1,
//	                x1 + (int) (headLength * Math.cos(angle - offs)) };
//	        int[] ys = { y1 + (int) (headLength * Math.sin(angle + offs)), y1,
//	                y1 + (int) (headLength * Math.sin(angle - offs)) };
//	        g.drawLine(x0, y0, x1, y1);
//	        g.drawPolyline(xs, ys, 3);
//	    }
	
//    static public void drawArrow(Graphics g, int x0, int y0, int x1,
//            int y1, int headLength, int headAngle) {
//        double offs = headAngle * Math.PI / 180.0;
//        double angle = Math.atan2(y0 - y1, x0 - x1);
//        int[] xs = { x1 + (int) (headLength * Math.cos(angle + offs)), x1,
//                x1 + (int) (headLength * Math.cos(angle - offs)) };
//        int[] ys = { y1 + (int) (headLength * Math.sin(angle + offs)), y1,
//                y1 + (int) (headLength * Math.sin(angle - offs)) };
//        g.drawLine(x0, y0, x1, y1);
//        g.drawPolyline(xs, ys, 3);
//    }
//	private void drawArrowHead(Graphics2D g2d) {  
//	    tx.setToIdentity();
//	    double angle = Math.atan2((int)(end.getY() - start.getY()), (int)(end.getX() - start.getX()));
//	    tx.translate(end.getX(), end.getY());
//	    tx.rotate((angle-Math.PI/2d));  
//
//	    Graphics2D g = (Graphics2D) g2d.create();
//	    g.setTransform(tx);   
//	    g.fill(arrowHead);
//	    g.dispose();
//	}
}
