package com.example.implementacion_androidmarket;

import android.R;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

public class MantenimientoSupermercado extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.mantenimiento_supermercado);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // TODO Auto-generated method stub
        getMenuInflater().inflate(R.menu.mantenimiento_supermercado, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // TODO Auto-generated method stub

        switch (item.getItemId()) {

            case R.id.buscar_supermercado:

                break;
            case R.id.nuevo_supermercado:

                Intent i = new Intent(this, NuevoSupermercado.class);
                startActivity(i);

                break;
            default:
                break;
        }

        return super.onOptionsItemSelected(item);
    }
}
