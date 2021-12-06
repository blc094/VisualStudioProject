package com.example.a19012021023_practical12


import android.content.Intent
import android.os.AsyncTask
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ListView
import org.json.JSONArray
import java.net.URL

class MainActivity : AppCompatActivity() {
    val listitems = Contact.contactArray as ArrayList<Contact>
    val adapter = ContactAdapter(this, listitems)
    lateinit var list: ListView
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        supportActionBar?.hide()




        list = findViewById(R.id.listrc)
        val arr = listitems
        list.setOnItemClickListener { parent, view, position, id ->
            val id: String = arr[position]._id.toString()
            val name: String = arr[position].name.toString()
            val num: String = arr[position].phone.toString()
            val addr: String = arr[position].address


        }
        contacts().execute()


    }

    inner class contacts() : AsyncTask<String, Void, String>() {
        override fun onPreExecute() {
            super.onPreExecute()

        }

        override fun doInBackground(vararg params: String?): String? {
            var response: String?
            try {
                response =
                    URL(
                        "\n" +
                                "\n" +
                                "https://api.json-generator.com/templates/mZ1w1lSjpdwB/data?access_token=gvqbj9e5d5tjcixhwll6hdn55h6cz60r3s3qxfdz "
                    ).readText(
                        Charsets.UTF_8
                    )

            } catch (e: Exception) {
                response = null
            }
            return response
        }

        override fun onPostExecute(result: String?) {
            super.onPostExecute(result)
            try {

                val jsonarr = JSONArray(result)

                for (i in 0..7) {

                    val jsonObj_0 = jsonarr.getJSONObject(i)
                    val id_json = "Person ID : " + jsonObj_0.getString("id")
                    val name_json = "Name : " + jsonObj_0.getString("Name")
                    val phone_json = "Phone No : " + jsonObj_0.getString("Phone")
                    val address_json = "Address : " + jsonObj_0.getString("Address")
                    listitems.add(Contact(id_json, name_json, phone_json, address_json))
                    list.adapter = adapter
                }


            } catch (e: Exception) {

            }

        }
    }
}

