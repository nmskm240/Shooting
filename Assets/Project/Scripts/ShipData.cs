using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShipData", menuName = "Shooting/ShipData", order = 0)]
public class ShipData : ScriptableObject
{
    [SerializeField]
    private string _name;
    [SerializeField, Multiline]
    private string _detail;
    [SerializeField]
    private int _hp;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _fireRate;
    [SerializeReference, SubclassSelector]
    private List<IMotion> _motions;

    public string Name { get { return _name; } }
    public string Detail { get { return _detail; } }
    public int HP { get { return _hp; } }
    public float Speed  { get { return _speed; } }
    public float FireRate { get { return _fireRate; } }
    public IEnumerable<IMotion> Motions { get { return _motions; } }
}