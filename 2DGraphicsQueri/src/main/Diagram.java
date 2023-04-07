package main;

import java.awt.Graphics;
import java.awt.Graphics2D;
import java.util.Vector;

public class Diagram {

	private Vector<Entity> entities;
	private Vector<Relationship> relationships;

	public Vector<Entity> getEntities() {
		return entities;
	}

	public void setEntities(Vector<Entity> entities) {
		this.entities = entities;
	}

	public Vector<Relationship> getRelationships() {
		return relationships;
	}

	public void setRelationships(Vector<Relationship> relationships) {
		this.relationships = relationships;
	}

	public Diagram(Vector<Entity> entities, Vector<Relationship> relationships) {
		super();
		this.entities = entities	;
		this.relationships = relationships;
	}
	
	public void drawDiagram(Graphics2D g2d) {
		
		for (Relationship relationship : relationships) {
			relationship.doDrawing(g2d);
		}
		
		for (Entity entity : entities) {
			entity.doDrawing(g2d);
		}
//		for (Entity entity : entities) {
//			entity.doDrawing(g2d);
//		}
		
		g2d.dispose();
	}
}
