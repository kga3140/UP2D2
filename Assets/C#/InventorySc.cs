using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class InventorySc : MonoBehaviour
{
	public List<string> tags = new List<string>();

	//gems

	public GameObject cut_emerald;
	public GameObject cut_ruby;
	public GameObject cut_saphire;
	public GameObject cut_topaz;
	public GameObject diamond;
	public GameObject raw_emerald;
	public GameObject raw_topaz;
	public GameObject raw_ruby;
	public GameObject raw_saphire;
	public GameObject crystal;

	//ores

	public GameObject coal;

	//ingots, nuggets

	public GameObject silver_ingot;
	public GameObject silver_nugget;
	public GameObject copper_ingot;
	public GameObject copper_nugget;
	public GameObject gold_ingot;
	public GameObject gold_nugget;

	//other

	public GameObject obsidian;
	public GameObject pearl;

	

	//gems int

	public int cut_emerald_int;
	public int cut_ruby_int;
	public int cut_saphire_int;
	public int cut_topaz_int;
	public int diamond_int;
	public int raw_emerald_int;
	public int raw_topaz_int;
	public int raw_ruby_int;
	public int raw_saphire_int;
	public int crystal_int;

	//ores int

	public int coal_int;

	//ingots, nuggets int

	public int silver_ingot_int;
	public int silver_nugget_int;
	public int copper_ingot_int;
	public int copper_nugget_int;
	public int gold_ingot_int;
	public int gold_nugget_int;

	//other int

	public int obsidian_int;
	public int pearl_int;

	void Start()
    {
		tags.Add("Coal");
		tags.Add("Cut Emerald");
		tags.Add("Copper ingot");
		tags.Add("Copper nugget");
		tags.Add("Crystal");
		tags.Add("Cut Emerald");
		tags.Add("Cut Ruby");
		tags.Add("Cut Saphire");
		tags.Add("Cut Topaz");
		tags.Add("Diamond");
		tags.Add("Raw Emerald");
		tags.Add("Gold Nugget");
		tags.Add("Gold Ingot");
		tags.Add("Obsidian");
		tags.Add("Pearl");
		tags.Add("Raw Ruby");
		tags.Add("Raw Saphire");
		tags.Add("Silver Ingot");
		tags.Add("Silver Nugget");
		tags.Add("Raw Topaz");
	}


    void Update()
    {
        
    }

	void OnCollisionEnter2(Collision collision)
	{	for (int i = 0; i < tags.Count; i++)
		{
			if (collision.collider.CompareTag("coal"))
			{

			}
		}
	}
}
