package main;

import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.geom.Point2D;
import java.util.Vector;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class MainClass {

	public static void main(String[] args) {
		
		new myFrame();
	}

}
class myFrame extends JFrame {
	
	public myFrame() {
		initUi();
	}

	private void initUi() {
		
//		add(new LinesSurface());
		Vector<Entity> entities = new Vector<Entity>();
		Entity en1 = new Entity(50, 50);
		Entity en2 = new Entity(200, 200);
		Entity en3 = new Entity(100, 400);
		AssocEntity ae1 = new AssocEntity(600, 450);
		InheritanceNode n1 = new InheritanceNode(650, 650);
		
		entities.add(en1);
		entities.add(en2);
		entities.add(en3);
		entities.add(ae1);
		entities.add(n1);
		
		Vector<Relationship> relationships = new Vector<>();
		relationships.add(new Relationship(75, 75, 150, 150));
		relationships.add(new Relationship(220, 220, 150, 375));
		relationships.add(new Relationship(50, 50, 600, 600));
		relationships.add(new AssociativeLink(50, 400, 800, 50));
		relationships.add(new InheritanceLink(700, 350, 400, 200));
		
		Diagram diagram = new Diagram(entities, relationships);
		MyPanel panel = new MyPanel(diagram);
		add(panel);
		
		setSize(1000, 1000);
		setLocationRelativeTo(null);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setTitle("BasicExample");
		setVisible(true);
	}
}