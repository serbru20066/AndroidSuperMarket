package com.example.implementacion_androidmarket;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

public class MantenimientoSupermercado extends Activity {
	
	TextView tv;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.mantenimiento_supermercado);
		
		tv = (TextView) findViewById(R.id.tvTexto);
	}	

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// TODO Auto-generated method stub
		getMenuInflater().inflate(R.menu.actionview_mantenimiento_supermercado, menu);
		return true;
	}	
	
	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// TODO Auto-generated method stub
		switch (item.getItemId()) {
		case R.id.buscar_supermercado:
			
			break;
		case R.id.nuevo_supermercado:

			break;
		default:
			break;
		}
		
		return super.onOptionsItemSelected(item);
	}
}
