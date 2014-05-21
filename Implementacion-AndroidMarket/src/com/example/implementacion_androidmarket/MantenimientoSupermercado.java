package com.example.implementacion_androidmarket;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;

public class MantenimientoSupermercado extends Activity {
	
	TextView tv;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.mantenimiento_supermercado);
		
		tv = (TextView) findViewById(R.id.tvTexto);
	}	
}
