// Attention: This file is generated. Any modifications will eventually be overwritten.
// Date: 06/09/2020 16:04:47

using System;
using System.Collections.Generic;
using System.Text;
using Semiodesk.Trinity;

namespace CWA_Graph
{
	
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public class rdf : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "rdf";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#"/>
    ///</summary>
    public static readonly Resource _22_rdf_syntax_ns = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));    

    ///<summary>
    ///The datatype of RDF literals storing fragments of HTML content
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"/>
    ///</summary>
    public static readonly Resource HTML = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"));    

    ///<summary>
    ///The datatype of language-tagged string values
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"/>
    ///</summary>
    public static readonly Resource langString = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"));    

    ///<summary>
    ///The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"/>
    ///</summary>
    public static readonly Resource PlainLiteral = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"));    

    ///<summary>
    ///The subject is an instance of a class.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"/>
    ///</summary>
    public static readonly Property type = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"));    

    ///<summary>
    ///The class of RDF properties.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"/>
    ///</summary>
    public static readonly Class Property = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"));    

    ///<summary>
    ///The class of RDF statements.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"/>
    ///</summary>
    public static readonly Class Statement = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"));    

    ///<summary>
    ///The subject of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"/>
    ///</summary>
    public static readonly Property subject = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"));    

    ///<summary>
    ///The predicate of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"/>
    ///</summary>
    public static readonly Property predicate = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"));    

    ///<summary>
    ///The object of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"/>
    ///</summary>
    public static readonly Property _object = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#object"));    

    ///<summary>
    ///The class of unordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"/>
    ///</summary>
    public static readonly Class Bag = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"));    

    ///<summary>
    ///The class of ordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"/>
    ///</summary>
    public static readonly Class Seq = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"));    

    ///<summary>
    ///The class of containers of alternatives.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"/>
    ///</summary>
    public static readonly Class Alt = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"));    

    ///<summary>
    ///Idiomatic property used for structured values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"/>
    ///</summary>
    public static readonly Property value = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#value"));    

    ///<summary>
    ///The class of RDF Lists.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"/>
    ///</summary>
    public static readonly Class List = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#List"));    

    ///<summary>
    ///The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"/>
    ///</summary>
    public static readonly Resource nil = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"));    

    ///<summary>
    ///The first item in the subject RDF list.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"/>
    ///</summary>
    public static readonly Property first = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#first"));    

    ///<summary>
    ///The rest of the subject RDF list after the first item.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"/>
    ///</summary>
    public static readonly Property rest = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"));    

    ///<summary>
    ///The datatype of XML literal values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"/>
    ///</summary>
    public static readonly Resource XMLLiteral = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"));    

    ///<summary>
    ///The datatype of RDF literals storing JSON content.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON"/>
    ///</summary>
    public static readonly Resource JSON = new Resource(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON"));    

    ///<summary>
    ///A class representing a compound literal.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral"/>
    ///</summary>
    public static readonly Class CompoundLiteral = new Class(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral"));    

    ///<summary>
    ///The language component of a CompoundLiteral.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#language"/>
    ///</summary>
    public static readonly Property language = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#language"));    

    ///<summary>
    ///The base direction component of a CompoundLiteral.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction"/>
    ///</summary>
    public static readonly Property direction = new Property(new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#direction"));
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public static class RDF
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "RDF";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#"/>
    ///</summary>
    public const string _22_rdf_syntax_ns = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";

    ///<summary>
    ///The datatype of RDF literals storing fragments of HTML content
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML"/>
    ///</summary>
    public const string HTML = "http://www.w3.org/1999/02/22-rdf-syntax-ns#HTML";

    ///<summary>
    ///The datatype of language-tagged string values
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#langString"/>
    ///</summary>
    public const string langString = "http://www.w3.org/1999/02/22-rdf-syntax-ns#langString";

    ///<summary>
    ///The class of plain (i.e. untyped) literal values, as used in RIF and OWL 2
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral"/>
    ///</summary>
    public const string PlainLiteral = "http://www.w3.org/1999/02/22-rdf-syntax-ns#PlainLiteral";

    ///<summary>
    ///The subject is an instance of a class.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#type"/>
    ///</summary>
    public const string type = "http://www.w3.org/1999/02/22-rdf-syntax-ns#type";

    ///<summary>
    ///The class of RDF properties.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Property"/>
    ///</summary>
    public const string Property = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Property";

    ///<summary>
    ///The class of RDF statements.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement"/>
    ///</summary>
    public const string Statement = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement";

    ///<summary>
    ///The subject of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#subject"/>
    ///</summary>
    public const string subject = "http://www.w3.org/1999/02/22-rdf-syntax-ns#subject";

    ///<summary>
    ///The predicate of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate"/>
    ///</summary>
    public const string predicate = "http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate";

    ///<summary>
    ///The object of the subject RDF statement.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#object"/>
    ///</summary>
    public const string _object = "http://www.w3.org/1999/02/22-rdf-syntax-ns#object";

    ///<summary>
    ///The class of unordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"/>
    ///</summary>
    public const string Bag = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag";

    ///<summary>
    ///The class of ordered containers.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq"/>
    ///</summary>
    public const string Seq = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq";

    ///<summary>
    ///The class of containers of alternatives.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt"/>
    ///</summary>
    public const string Alt = "http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt";

    ///<summary>
    ///Idiomatic property used for structured values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#value"/>
    ///</summary>
    public const string value = "http://www.w3.org/1999/02/22-rdf-syntax-ns#value";

    ///<summary>
    ///The class of RDF Lists.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#List"/>
    ///</summary>
    public const string List = "http://www.w3.org/1999/02/22-rdf-syntax-ns#List";

    ///<summary>
    ///The empty list, with no items in it. If the rest of a list is nil then the list has no more items in it.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#nil"/>
    ///</summary>
    public const string nil = "http://www.w3.org/1999/02/22-rdf-syntax-ns#nil";

    ///<summary>
    ///The first item in the subject RDF list.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#first"/>
    ///</summary>
    public const string first = "http://www.w3.org/1999/02/22-rdf-syntax-ns#first";

    ///<summary>
    ///The rest of the subject RDF list after the first item.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#rest"/>
    ///</summary>
    public const string rest = "http://www.w3.org/1999/02/22-rdf-syntax-ns#rest";

    ///<summary>
    ///The datatype of XML literal values.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral"/>
    ///</summary>
    public const string XMLLiteral = "http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral";

    ///<summary>
    ///The datatype of RDF literals storing JSON content.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON"/>
    ///</summary>
    public const string JSON = "http://www.w3.org/1999/02/22-rdf-syntax-ns#JSON";

    ///<summary>
    ///A class representing a compound literal.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral"/>
    ///</summary>
    public const string CompoundLiteral = "http://www.w3.org/1999/02/22-rdf-syntax-ns#CompoundLiteral";

    ///<summary>
    ///The language component of a CompoundLiteral.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#language"/>
    ///</summary>
    public const string language = "http://www.w3.org/1999/02/22-rdf-syntax-ns#language";

    ///<summary>
    ///The base direction component of a CompoundLiteral.
    ///<see cref="http://www.w3.org/1999/02/22-rdf-syntax-ns#direction"/>
    ///</summary>
    public const string direction = "http://www.w3.org/1999/02/22-rdf-syntax-ns#direction";
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public class rdfs : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2000/01/rdf-schema#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "rdfs";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#"/>
    ///</summary>
    public static readonly Resource rdf_schema = new Resource(new Uri("http://www.w3.org/2000/01/rdf-schema#"));    

    ///<summary>
    ///The class resource, everything.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Resource"/>
    ///</summary>
    public static readonly Class Resource = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Resource"));    

    ///<summary>
    ///The class of classes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public static readonly Class Class = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Class"));    

    ///<summary>
    ///The subject is a subclass of a class.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subClassOf"/>
    ///</summary>
    public static readonly Property subClassOf = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#subClassOf"));    

    ///<summary>
    ///The subject is a subproperty of a property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"/>
    ///</summary>
    public static readonly Property subPropertyOf = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#subPropertyOf"));    

    ///<summary>
    ///A description of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#comment"/>
    ///</summary>
    public static readonly Property comment = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#comment"));    

    ///<summary>
    ///A human-readable name for the subject.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#label"/>
    ///</summary>
    public static readonly Property label = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#label"));    

    ///<summary>
    ///A domain of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#domain"/>
    ///</summary>
    public static readonly Property domain = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#domain"));    

    ///<summary>
    ///A range of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#range"/>
    ///</summary>
    public static readonly Property range = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#range"));    

    ///<summary>
    ///Further information about the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#seeAlso"/>
    ///</summary>
    public static readonly Property seeAlso = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#seeAlso"));    

    ///<summary>
    ///The defininition of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"/>
    ///</summary>
    public static readonly Property isDefinedBy = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#isDefinedBy"));    

    ///<summary>
    ///The class of literal values, eg. textual strings and integers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Literal"/>
    ///</summary>
    public static readonly Class Literal = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Literal"));    

    ///<summary>
    ///The class of RDF containers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Container"/>
    ///</summary>
    public static readonly Class Container = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Container"));    

    ///<summary>
    ///The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                    all of which are sub-properties of 'member'.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"/>
    ///</summary>
    public static readonly Class ContainerMembershipProperty = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"));    

    ///<summary>
    ///A member of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#member"/>
    ///</summary>
    public static readonly Property member = new Property(new Uri("http://www.w3.org/2000/01/rdf-schema#member"));    

    ///<summary>
    ///The class of RDF datatypes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Datatype"/>
    ///</summary>
    public static readonly Class Datatype = new Class(new Uri("http://www.w3.org/2000/01/rdf-schema#Datatype"));
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public static class RDFS
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2000/01/rdf-schema#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "RDFS";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#"/>
    ///</summary>
    public const string rdf_schema = "http://www.w3.org/2000/01/rdf-schema#";

    ///<summary>
    ///The class resource, everything.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Resource"/>
    ///</summary>
    public const string Resource = "http://www.w3.org/2000/01/rdf-schema#Resource";

    ///<summary>
    ///The class of classes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Class"/>
    ///</summary>
    public const string Class = "http://www.w3.org/2000/01/rdf-schema#Class";

    ///<summary>
    ///The subject is a subclass of a class.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subClassOf"/>
    ///</summary>
    public const string subClassOf = "http://www.w3.org/2000/01/rdf-schema#subClassOf";

    ///<summary>
    ///The subject is a subproperty of a property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"/>
    ///</summary>
    public const string subPropertyOf = "http://www.w3.org/2000/01/rdf-schema#subPropertyOf";

    ///<summary>
    ///A description of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#comment"/>
    ///</summary>
    public const string comment = "http://www.w3.org/2000/01/rdf-schema#comment";

    ///<summary>
    ///A human-readable name for the subject.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#label"/>
    ///</summary>
    public const string label = "http://www.w3.org/2000/01/rdf-schema#label";

    ///<summary>
    ///A domain of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#domain"/>
    ///</summary>
    public const string domain = "http://www.w3.org/2000/01/rdf-schema#domain";

    ///<summary>
    ///A range of the subject property.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#range"/>
    ///</summary>
    public const string range = "http://www.w3.org/2000/01/rdf-schema#range";

    ///<summary>
    ///Further information about the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#seeAlso"/>
    ///</summary>
    public const string seeAlso = "http://www.w3.org/2000/01/rdf-schema#seeAlso";

    ///<summary>
    ///The defininition of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"/>
    ///</summary>
    public const string isDefinedBy = "http://www.w3.org/2000/01/rdf-schema#isDefinedBy";

    ///<summary>
    ///The class of literal values, eg. textual strings and integers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Literal"/>
    ///</summary>
    public const string Literal = "http://www.w3.org/2000/01/rdf-schema#Literal";

    ///<summary>
    ///The class of RDF containers.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Container"/>
    ///</summary>
    public const string Container = "http://www.w3.org/2000/01/rdf-schema#Container";

    ///<summary>
    ///The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                    all of which are sub-properties of 'member'.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"/>
    ///</summary>
    public const string ContainerMembershipProperty = "http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty";

    ///<summary>
    ///A member of the subject resource.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#member"/>
    ///</summary>
    public const string member = "http://www.w3.org/2000/01/rdf-schema#member";

    ///<summary>
    ///The class of RDF datatypes.
    ///<see cref="http://www.w3.org/2000/01/rdf-schema#Datatype"/>
    ///</summary>
    public const string Datatype = "http://www.w3.org/2000/01/rdf-schema#Datatype";
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public class owl : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2002/07/owl#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "owl";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///The class of collections of pairwise different individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDifferent"/>
    ///</summary>
    public static readonly Class AllDifferent = new Class(new Uri("http://www.w3.org/2002/07/owl#AllDifferent"));    

    ///<summary>
    ///The class of collections of pairwise disjoint classes.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointClasses"/>
    ///</summary>
    public static readonly Class AllDisjointClasses = new Class(new Uri("http://www.w3.org/2002/07/owl#AllDisjointClasses"));    

    ///<summary>
    ///The class of collections of pairwise disjoint properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointProperties"/>
    ///</summary>
    public static readonly Class AllDisjointProperties = new Class(new Uri("http://www.w3.org/2002/07/owl#AllDisjointProperties"));    

    ///<summary>
    ///The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Annotation"/>
    ///</summary>
    public static readonly Class Annotation = new Class(new Uri("http://www.w3.org/2002/07/owl#Annotation"));    

    ///<summary>
    ///The class of annotation properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AnnotationProperty"/>
    ///</summary>
    public static readonly Class AnnotationProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#AnnotationProperty"));    

    ///<summary>
    ///The class of asymmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AsymmetricProperty"/>
    ///</summary>
    public static readonly Class AsymmetricProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#AsymmetricProperty"));    

    ///<summary>
    ///The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Axiom"/>
    ///</summary>
    public static readonly Class Axiom = new Class(new Uri("http://www.w3.org/2002/07/owl#Axiom"));    

    ///<summary>
    ///The class of OWL classes.
    ///<see cref="http://www.w3.org/2002/07/owl#Class"/>
    ///</summary>
    public static readonly Class Class = new Class(new Uri("http://www.w3.org/2002/07/owl#Class"));    

    ///<summary>
    ///The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    ///<see cref="http://www.w3.org/2002/07/owl#DataRange"/>
    ///</summary>
    public static readonly Class DataRange = new Class(new Uri("http://www.w3.org/2002/07/owl#DataRange"));    

    ///<summary>
    ///The class of data properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DatatypeProperty"/>
    ///</summary>
    public static readonly Class DatatypeProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#DatatypeProperty"));    

    ///<summary>
    ///The class of deprecated classes.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedClass"/>
    ///</summary>
    public static readonly Class DeprecatedClass = new Class(new Uri("http://www.w3.org/2002/07/owl#DeprecatedClass"));    

    ///<summary>
    ///The class of deprecated properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedProperty"/>
    ///</summary>
    public static readonly Class DeprecatedProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#DeprecatedProperty"));    

    ///<summary>
    ///The class of functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#FunctionalProperty"/>
    ///</summary>
    public static readonly Class FunctionalProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#FunctionalProperty"));    

    ///<summary>
    ///The class of inverse-functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#InverseFunctionalProperty"/>
    ///</summary>
    public static readonly Class InverseFunctionalProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#InverseFunctionalProperty"));    

    ///<summary>
    ///The class of irreflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#IrreflexiveProperty"/>
    ///</summary>
    public static readonly Class IrreflexiveProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#IrreflexiveProperty"));    

    ///<summary>
    ///The class of named individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#NamedIndividual"/>
    ///</summary>
    public static readonly Class NamedIndividual = new Class(new Uri("http://www.w3.org/2002/07/owl#NamedIndividual"));    

    ///<summary>
    ///The class of negative property assertions.
    ///<see cref="http://www.w3.org/2002/07/owl#NegativePropertyAssertion"/>
    ///</summary>
    public static readonly Class NegativePropertyAssertion = new Class(new Uri("http://www.w3.org/2002/07/owl#NegativePropertyAssertion"));    

    ///<summary>
    ///This is the empty class.
    ///<see cref="http://www.w3.org/2002/07/owl#Nothing"/>
    ///</summary>
    public static readonly Class Nothing = new Class(new Uri("http://www.w3.org/2002/07/owl#Nothing"));    

    ///<summary>
    ///The class of object properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ObjectProperty"/>
    ///</summary>
    public static readonly Class ObjectProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#ObjectProperty"));    

    ///<summary>
    ///The class of ontologies.
    ///<see cref="http://www.w3.org/2002/07/owl#Ontology"/>
    ///</summary>
    public static readonly Class Ontology = new Class(new Uri("http://www.w3.org/2002/07/owl#Ontology"));    

    ///<summary>
    ///The class of ontology properties.
    ///<see cref="http://www.w3.org/2002/07/owl#OntologyProperty"/>
    ///</summary>
    public static readonly Class OntologyProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#OntologyProperty"));    

    ///<summary>
    ///The class of reflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ReflexiveProperty"/>
    ///</summary>
    public static readonly Class ReflexiveProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#ReflexiveProperty"));    

    ///<summary>
    ///The class of property restrictions.
    ///<see cref="http://www.w3.org/2002/07/owl#Restriction"/>
    ///</summary>
    public static readonly Class Restriction = new Class(new Uri("http://www.w3.org/2002/07/owl#Restriction"));    

    ///<summary>
    ///The class of symmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#SymmetricProperty"/>
    ///</summary>
    public static readonly Class SymmetricProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#SymmetricProperty"));    

    ///<summary>
    ///The class of transitive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#TransitiveProperty"/>
    ///</summary>
    public static readonly Class TransitiveProperty = new Class(new Uri("http://www.w3.org/2002/07/owl#TransitiveProperty"));    

    ///<summary>
    ///The class of OWL individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#Thing"/>
    ///</summary>
    public static readonly Class Thing = new Class(new Uri("http://www.w3.org/2002/07/owl#Thing"));    

    ///<summary>
    ///The property that determines the class that a universal property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#allValuesFrom"/>
    ///</summary>
    public static readonly Property allValuesFrom = new Property(new Uri("http://www.w3.org/2002/07/owl#allValuesFrom"));    

    ///<summary>
    ///The property that determines the predicate of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedProperty"/>
    ///</summary>
    public static readonly Property annotatedProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#annotatedProperty"));    

    ///<summary>
    ///The property that determines the subject of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedSource"/>
    ///</summary>
    public static readonly Property annotatedSource = new Property(new Uri("http://www.w3.org/2002/07/owl#annotatedSource"));    

    ///<summary>
    ///The property that determines the object of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedTarget"/>
    ///</summary>
    public static readonly Property annotatedTarget = new Property(new Uri("http://www.w3.org/2002/07/owl#annotatedTarget"));    

    ///<summary>
    ///The property that determines the predicate of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#assertionProperty"/>
    ///</summary>
    public static readonly Property assertionProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#assertionProperty"));    

    ///<summary>
    ///The annotation property that indicates that a given ontology is backward compatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#backwardCompatibleWith"/>
    ///</summary>
    public static readonly Property backwardCompatibleWith = new Property(new Uri("http://www.w3.org/2002/07/owl#backwardCompatibleWith"));    

    ///<summary>
    ///The data property that does not relate any individual to any data value.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomDataProperty"/>
    ///</summary>
    public static readonly Property bottomDataProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#bottomDataProperty"));    

    ///<summary>
    ///The object property that does not relate any two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomObjectProperty"/>
    ///</summary>
    public static readonly Property bottomObjectProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#bottomObjectProperty"));    

    ///<summary>
    ///The property that determines the cardinality of an exact cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#cardinality"/>
    ///</summary>
    public static readonly Property cardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#cardinality"));    

    ///<summary>
    ///The property that determines that a given class is the complement of another class.
    ///<see cref="http://www.w3.org/2002/07/owl#complementOf"/>
    ///</summary>
    public static readonly Property complementOf = new Property(new Uri("http://www.w3.org/2002/07/owl#complementOf"));    

    ///<summary>
    ///The property that determines that a given data range is the complement of another data range with respect to the data domain.
    ///<see cref="http://www.w3.org/2002/07/owl#datatypeComplementOf"/>
    ///</summary>
    public static readonly Property datatypeComplementOf = new Property(new Uri("http://www.w3.org/2002/07/owl#datatypeComplementOf"));    

    ///<summary>
    ///The annotation property that indicates that a given entity has been deprecated.
    ///<see cref="http://www.w3.org/2002/07/owl#deprecated"/>
    ///</summary>
    public static readonly Property deprecated = new Property(new Uri("http://www.w3.org/2002/07/owl#deprecated"));    

    ///<summary>
    ///The property that determines that two given individuals are different.
    ///<see cref="http://www.w3.org/2002/07/owl#differentFrom"/>
    ///</summary>
    public static readonly Property differentFrom = new Property(new Uri("http://www.w3.org/2002/07/owl#differentFrom"));    

    ///<summary>
    ///The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointUnionOf"/>
    ///</summary>
    public static readonly Property disjointUnionOf = new Property(new Uri("http://www.w3.org/2002/07/owl#disjointUnionOf"));    

    ///<summary>
    ///The property that determines that two given classes are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointWith"/>
    ///</summary>
    public static readonly Property disjointWith = new Property(new Uri("http://www.w3.org/2002/07/owl#disjointWith"));    

    ///<summary>
    ///The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#distinctMembers"/>
    ///</summary>
    public static readonly Property distinctMembers = new Property(new Uri("http://www.w3.org/2002/07/owl#distinctMembers"));    

    ///<summary>
    ///The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentClass"/>
    ///</summary>
    public static readonly Property equivalentClass = new Property(new Uri("http://www.w3.org/2002/07/owl#equivalentClass"));    

    ///<summary>
    ///The property that determines that two given properties are equivalent.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentProperty"/>
    ///</summary>
    public static readonly Property equivalentProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#equivalentProperty"));    

    ///<summary>
    ///The property that determines the collection of properties that jointly build a key.
    ///<see cref="http://www.w3.org/2002/07/owl#hasKey"/>
    ///</summary>
    public static readonly Property hasKey = new Property(new Uri("http://www.w3.org/2002/07/owl#hasKey"));    

    ///<summary>
    ///The property that determines the property that a self restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasSelf"/>
    ///</summary>
    public static readonly Property hasSelf = new Property(new Uri("http://www.w3.org/2002/07/owl#hasSelf"));    

    ///<summary>
    ///The property that determines the individual that a has-value restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasValue"/>
    ///</summary>
    public static readonly Property hasValue = new Property(new Uri("http://www.w3.org/2002/07/owl#hasValue"));    

    ///<summary>
    ///The property that is used for importing other ontologies into a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#imports"/>
    ///</summary>
    public static readonly Property imports = new Property(new Uri("http://www.w3.org/2002/07/owl#imports"));    

    ///<summary>
    ///The annotation property that indicates that a given ontology is incompatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#incompatibleWith"/>
    ///</summary>
    public static readonly Property incompatibleWith = new Property(new Uri("http://www.w3.org/2002/07/owl#incompatibleWith"));    

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build an intersection.
    ///<see cref="http://www.w3.org/2002/07/owl#intersectionOf"/>
    ///</summary>
    public static readonly Property intersectionOf = new Property(new Uri("http://www.w3.org/2002/07/owl#intersectionOf"));    

    ///<summary>
    ///The property that determines that two given properties are inverse.
    ///<see cref="http://www.w3.org/2002/07/owl#inverseOf"/>
    ///</summary>
    public static readonly Property inverseOf = new Property(new Uri("http://www.w3.org/2002/07/owl#inverseOf"));    

    ///<summary>
    ///The property that determines the cardinality of a maximum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxCardinality"/>
    ///</summary>
    public static readonly Property maxCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#maxCardinality"));    

    ///<summary>
    ///The property that determines the cardinality of a maximum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxQualifiedCardinality"/>
    ///</summary>
    public static readonly Property maxQualifiedCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#maxQualifiedCardinality"));    

    ///<summary>
    ///The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#members"/>
    ///</summary>
    public static readonly Property members = new Property(new Uri("http://www.w3.org/2002/07/owl#members"));    

    ///<summary>
    ///The property that determines the cardinality of a minimum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minCardinality"/>
    ///</summary>
    public static readonly Property minCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#minCardinality"));    

    ///<summary>
    ///The property that determines the cardinality of a minimum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minQualifiedCardinality"/>
    ///</summary>
    public static readonly Property minQualifiedCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#minQualifiedCardinality"));    

    ///<summary>
    ///The property that determines the class that a qualified object cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onClass"/>
    ///</summary>
    public static readonly Property onClass = new Property(new Uri("http://www.w3.org/2002/07/owl#onClass"));    

    ///<summary>
    ///The property that determines the data range that a qualified data cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDataRange"/>
    ///</summary>
    public static readonly Property onDataRange = new Property(new Uri("http://www.w3.org/2002/07/owl#onDataRange"));    

    ///<summary>
    ///The property that determines the datatype that a datatype restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDatatype"/>
    ///</summary>
    public static readonly Property onDatatype = new Property(new Uri("http://www.w3.org/2002/07/owl#onDatatype"));    

    ///<summary>
    ///The property that determines the collection of individuals or data values that build an enumeration.
    ///<see cref="http://www.w3.org/2002/07/owl#oneOf"/>
    ///</summary>
    public static readonly Property oneOf = new Property(new Uri("http://www.w3.org/2002/07/owl#oneOf"));    

    ///<summary>
    ///The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperties"/>
    ///</summary>
    public static readonly Property onProperties = new Property(new Uri("http://www.w3.org/2002/07/owl#onProperties"));    

    ///<summary>
    ///The property that determines the property that a property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperty"/>
    ///</summary>
    public static readonly Property onProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#onProperty"));    

    ///<summary>
    ///The annotation property that indicates the predecessor ontology of a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#priorVersion"/>
    ///</summary>
    public static readonly Property priorVersion = new Property(new Uri("http://www.w3.org/2002/07/owl#priorVersion"));    

    ///<summary>
    ///The property that determines the n-tuple of properties that build a sub property chain of a given property.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyChainAxiom"/>
    ///</summary>
    public static readonly Property propertyChainAxiom = new Property(new Uri("http://www.w3.org/2002/07/owl#propertyChainAxiom"));    

    ///<summary>
    ///The property that determines that two given properties are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyDisjointWith"/>
    ///</summary>
    public static readonly Property propertyDisjointWith = new Property(new Uri("http://www.w3.org/2002/07/owl#propertyDisjointWith"));    

    ///<summary>
    ///The property that determines the cardinality of an exact qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#qualifiedCardinality"/>
    ///</summary>
    public static readonly Property qualifiedCardinality = new Property(new Uri("http://www.w3.org/2002/07/owl#qualifiedCardinality"));    

    ///<summary>
    ///The property that determines that two given individuals are equal.
    ///<see cref="http://www.w3.org/2002/07/owl#sameAs"/>
    ///</summary>
    public static readonly Property sameAs = new Property(new Uri("http://www.w3.org/2002/07/owl#sameAs"));    

    ///<summary>
    ///The property that determines the class that an existential property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#someValuesFrom"/>
    ///</summary>
    public static readonly Property someValuesFrom = new Property(new Uri("http://www.w3.org/2002/07/owl#someValuesFrom"));    

    ///<summary>
    ///The property that determines the subject of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#sourceIndividual"/>
    ///</summary>
    public static readonly Property sourceIndividual = new Property(new Uri("http://www.w3.org/2002/07/owl#sourceIndividual"));    

    ///<summary>
    ///The property that determines the object of a negative object property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetIndividual"/>
    ///</summary>
    public static readonly Property targetIndividual = new Property(new Uri("http://www.w3.org/2002/07/owl#targetIndividual"));    

    ///<summary>
    ///The property that determines the value of a negative data property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetValue"/>
    ///</summary>
    public static readonly Property targetValue = new Property(new Uri("http://www.w3.org/2002/07/owl#targetValue"));    

    ///<summary>
    ///The data property that relates every individual to every data value.
    ///<see cref="http://www.w3.org/2002/07/owl#topDataProperty"/>
    ///</summary>
    public static readonly Property topDataProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#topDataProperty"));    

    ///<summary>
    ///The object property that relates every two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#topObjectProperty"/>
    ///</summary>
    public static readonly Property topObjectProperty = new Property(new Uri("http://www.w3.org/2002/07/owl#topObjectProperty"));    

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build a union.
    ///<see cref="http://www.w3.org/2002/07/owl#unionOf"/>
    ///</summary>
    public static readonly Property unionOf = new Property(new Uri("http://www.w3.org/2002/07/owl#unionOf"));    

    ///<summary>
    ///The annotation property that provides version information for an ontology or another OWL construct.
    ///<see cref="http://www.w3.org/2002/07/owl#versionInfo"/>
    ///</summary>
    public static readonly Property versionInfo = new Property(new Uri("http://www.w3.org/2002/07/owl#versionInfo"));    

    ///<summary>
    ///The property that identifies the version IRI of an ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#versionIRI"/>
    ///</summary>
    public static readonly Property versionIRI = new Property(new Uri("http://www.w3.org/2002/07/owl#versionIRI"));    

    ///<summary>
    ///The property that determines the collection of facet-value pairs that define a datatype restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#withRestrictions"/>
    ///</summary>
    public static readonly Property withRestrictions = new Property(new Uri("http://www.w3.org/2002/07/owl#withRestrictions"));
}
///<summary>
///Semiodesk.Trinity.BindingSet
///
///</summary>
public static class OWL
{
    public static readonly Uri Namespace = new Uri("http://www.w3.org/2002/07/owl#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "OWL";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///The class of collections of pairwise different individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDifferent"/>
    ///</summary>
    public const string AllDifferent = "http://www.w3.org/2002/07/owl#AllDifferent";

    ///<summary>
    ///The class of collections of pairwise disjoint classes.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointClasses"/>
    ///</summary>
    public const string AllDisjointClasses = "http://www.w3.org/2002/07/owl#AllDisjointClasses";

    ///<summary>
    ///The class of collections of pairwise disjoint properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AllDisjointProperties"/>
    ///</summary>
    public const string AllDisjointProperties = "http://www.w3.org/2002/07/owl#AllDisjointProperties";

    ///<summary>
    ///The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Annotation"/>
    ///</summary>
    public const string Annotation = "http://www.w3.org/2002/07/owl#Annotation";

    ///<summary>
    ///The class of annotation properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AnnotationProperty"/>
    ///</summary>
    public const string AnnotationProperty = "http://www.w3.org/2002/07/owl#AnnotationProperty";

    ///<summary>
    ///The class of asymmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#AsymmetricProperty"/>
    ///</summary>
    public const string AsymmetricProperty = "http://www.w3.org/2002/07/owl#AsymmetricProperty";

    ///<summary>
    ///The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    ///<see cref="http://www.w3.org/2002/07/owl#Axiom"/>
    ///</summary>
    public const string Axiom = "http://www.w3.org/2002/07/owl#Axiom";

    ///<summary>
    ///The class of OWL classes.
    ///<see cref="http://www.w3.org/2002/07/owl#Class"/>
    ///</summary>
    public const string Class = "http://www.w3.org/2002/07/owl#Class";

    ///<summary>
    ///The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    ///<see cref="http://www.w3.org/2002/07/owl#DataRange"/>
    ///</summary>
    public const string DataRange = "http://www.w3.org/2002/07/owl#DataRange";

    ///<summary>
    ///The class of data properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DatatypeProperty"/>
    ///</summary>
    public const string DatatypeProperty = "http://www.w3.org/2002/07/owl#DatatypeProperty";

    ///<summary>
    ///The class of deprecated classes.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedClass"/>
    ///</summary>
    public const string DeprecatedClass = "http://www.w3.org/2002/07/owl#DeprecatedClass";

    ///<summary>
    ///The class of deprecated properties.
    ///<see cref="http://www.w3.org/2002/07/owl#DeprecatedProperty"/>
    ///</summary>
    public const string DeprecatedProperty = "http://www.w3.org/2002/07/owl#DeprecatedProperty";

    ///<summary>
    ///The class of functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#FunctionalProperty"/>
    ///</summary>
    public const string FunctionalProperty = "http://www.w3.org/2002/07/owl#FunctionalProperty";

    ///<summary>
    ///The class of inverse-functional properties.
    ///<see cref="http://www.w3.org/2002/07/owl#InverseFunctionalProperty"/>
    ///</summary>
    public const string InverseFunctionalProperty = "http://www.w3.org/2002/07/owl#InverseFunctionalProperty";

    ///<summary>
    ///The class of irreflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#IrreflexiveProperty"/>
    ///</summary>
    public const string IrreflexiveProperty = "http://www.w3.org/2002/07/owl#IrreflexiveProperty";

    ///<summary>
    ///The class of named individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#NamedIndividual"/>
    ///</summary>
    public const string NamedIndividual = "http://www.w3.org/2002/07/owl#NamedIndividual";

    ///<summary>
    ///The class of negative property assertions.
    ///<see cref="http://www.w3.org/2002/07/owl#NegativePropertyAssertion"/>
    ///</summary>
    public const string NegativePropertyAssertion = "http://www.w3.org/2002/07/owl#NegativePropertyAssertion";

    ///<summary>
    ///This is the empty class.
    ///<see cref="http://www.w3.org/2002/07/owl#Nothing"/>
    ///</summary>
    public const string Nothing = "http://www.w3.org/2002/07/owl#Nothing";

    ///<summary>
    ///The class of object properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ObjectProperty"/>
    ///</summary>
    public const string ObjectProperty = "http://www.w3.org/2002/07/owl#ObjectProperty";

    ///<summary>
    ///The class of ontologies.
    ///<see cref="http://www.w3.org/2002/07/owl#Ontology"/>
    ///</summary>
    public const string Ontology = "http://www.w3.org/2002/07/owl#Ontology";

    ///<summary>
    ///The class of ontology properties.
    ///<see cref="http://www.w3.org/2002/07/owl#OntologyProperty"/>
    ///</summary>
    public const string OntologyProperty = "http://www.w3.org/2002/07/owl#OntologyProperty";

    ///<summary>
    ///The class of reflexive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#ReflexiveProperty"/>
    ///</summary>
    public const string ReflexiveProperty = "http://www.w3.org/2002/07/owl#ReflexiveProperty";

    ///<summary>
    ///The class of property restrictions.
    ///<see cref="http://www.w3.org/2002/07/owl#Restriction"/>
    ///</summary>
    public const string Restriction = "http://www.w3.org/2002/07/owl#Restriction";

    ///<summary>
    ///The class of symmetric properties.
    ///<see cref="http://www.w3.org/2002/07/owl#SymmetricProperty"/>
    ///</summary>
    public const string SymmetricProperty = "http://www.w3.org/2002/07/owl#SymmetricProperty";

    ///<summary>
    ///The class of transitive properties.
    ///<see cref="http://www.w3.org/2002/07/owl#TransitiveProperty"/>
    ///</summary>
    public const string TransitiveProperty = "http://www.w3.org/2002/07/owl#TransitiveProperty";

    ///<summary>
    ///The class of OWL individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#Thing"/>
    ///</summary>
    public const string Thing = "http://www.w3.org/2002/07/owl#Thing";

    ///<summary>
    ///The property that determines the class that a universal property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#allValuesFrom"/>
    ///</summary>
    public const string allValuesFrom = "http://www.w3.org/2002/07/owl#allValuesFrom";

    ///<summary>
    ///The property that determines the predicate of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedProperty"/>
    ///</summary>
    public const string annotatedProperty = "http://www.w3.org/2002/07/owl#annotatedProperty";

    ///<summary>
    ///The property that determines the subject of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedSource"/>
    ///</summary>
    public const string annotatedSource = "http://www.w3.org/2002/07/owl#annotatedSource";

    ///<summary>
    ///The property that determines the object of an annotated axiom or annotated annotation.
    ///<see cref="http://www.w3.org/2002/07/owl#annotatedTarget"/>
    ///</summary>
    public const string annotatedTarget = "http://www.w3.org/2002/07/owl#annotatedTarget";

    ///<summary>
    ///The property that determines the predicate of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#assertionProperty"/>
    ///</summary>
    public const string assertionProperty = "http://www.w3.org/2002/07/owl#assertionProperty";

    ///<summary>
    ///The annotation property that indicates that a given ontology is backward compatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#backwardCompatibleWith"/>
    ///</summary>
    public const string backwardCompatibleWith = "http://www.w3.org/2002/07/owl#backwardCompatibleWith";

    ///<summary>
    ///The data property that does not relate any individual to any data value.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomDataProperty"/>
    ///</summary>
    public const string bottomDataProperty = "http://www.w3.org/2002/07/owl#bottomDataProperty";

    ///<summary>
    ///The object property that does not relate any two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#bottomObjectProperty"/>
    ///</summary>
    public const string bottomObjectProperty = "http://www.w3.org/2002/07/owl#bottomObjectProperty";

    ///<summary>
    ///The property that determines the cardinality of an exact cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#cardinality"/>
    ///</summary>
    public const string cardinality = "http://www.w3.org/2002/07/owl#cardinality";

    ///<summary>
    ///The property that determines that a given class is the complement of another class.
    ///<see cref="http://www.w3.org/2002/07/owl#complementOf"/>
    ///</summary>
    public const string complementOf = "http://www.w3.org/2002/07/owl#complementOf";

    ///<summary>
    ///The property that determines that a given data range is the complement of another data range with respect to the data domain.
    ///<see cref="http://www.w3.org/2002/07/owl#datatypeComplementOf"/>
    ///</summary>
    public const string datatypeComplementOf = "http://www.w3.org/2002/07/owl#datatypeComplementOf";

    ///<summary>
    ///The annotation property that indicates that a given entity has been deprecated.
    ///<see cref="http://www.w3.org/2002/07/owl#deprecated"/>
    ///</summary>
    public const string deprecated = "http://www.w3.org/2002/07/owl#deprecated";

    ///<summary>
    ///The property that determines that two given individuals are different.
    ///<see cref="http://www.w3.org/2002/07/owl#differentFrom"/>
    ///</summary>
    public const string differentFrom = "http://www.w3.org/2002/07/owl#differentFrom";

    ///<summary>
    ///The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointUnionOf"/>
    ///</summary>
    public const string disjointUnionOf = "http://www.w3.org/2002/07/owl#disjointUnionOf";

    ///<summary>
    ///The property that determines that two given classes are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#disjointWith"/>
    ///</summary>
    public const string disjointWith = "http://www.w3.org/2002/07/owl#disjointWith";

    ///<summary>
    ///The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#distinctMembers"/>
    ///</summary>
    public const string distinctMembers = "http://www.w3.org/2002/07/owl#distinctMembers";

    ///<summary>
    ///The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentClass"/>
    ///</summary>
    public const string equivalentClass = "http://www.w3.org/2002/07/owl#equivalentClass";

    ///<summary>
    ///The property that determines that two given properties are equivalent.
    ///<see cref="http://www.w3.org/2002/07/owl#equivalentProperty"/>
    ///</summary>
    public const string equivalentProperty = "http://www.w3.org/2002/07/owl#equivalentProperty";

    ///<summary>
    ///The property that determines the collection of properties that jointly build a key.
    ///<see cref="http://www.w3.org/2002/07/owl#hasKey"/>
    ///</summary>
    public const string hasKey = "http://www.w3.org/2002/07/owl#hasKey";

    ///<summary>
    ///The property that determines the property that a self restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasSelf"/>
    ///</summary>
    public const string hasSelf = "http://www.w3.org/2002/07/owl#hasSelf";

    ///<summary>
    ///The property that determines the individual that a has-value restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#hasValue"/>
    ///</summary>
    public const string hasValue = "http://www.w3.org/2002/07/owl#hasValue";

    ///<summary>
    ///The property that is used for importing other ontologies into a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#imports"/>
    ///</summary>
    public const string imports = "http://www.w3.org/2002/07/owl#imports";

    ///<summary>
    ///The annotation property that indicates that a given ontology is incompatible with another ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#incompatibleWith"/>
    ///</summary>
    public const string incompatibleWith = "http://www.w3.org/2002/07/owl#incompatibleWith";

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build an intersection.
    ///<see cref="http://www.w3.org/2002/07/owl#intersectionOf"/>
    ///</summary>
    public const string intersectionOf = "http://www.w3.org/2002/07/owl#intersectionOf";

    ///<summary>
    ///The property that determines that two given properties are inverse.
    ///<see cref="http://www.w3.org/2002/07/owl#inverseOf"/>
    ///</summary>
    public const string inverseOf = "http://www.w3.org/2002/07/owl#inverseOf";

    ///<summary>
    ///The property that determines the cardinality of a maximum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxCardinality"/>
    ///</summary>
    public const string maxCardinality = "http://www.w3.org/2002/07/owl#maxCardinality";

    ///<summary>
    ///The property that determines the cardinality of a maximum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#maxQualifiedCardinality"/>
    ///</summary>
    public const string maxQualifiedCardinality = "http://www.w3.org/2002/07/owl#maxQualifiedCardinality";

    ///<summary>
    ///The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    ///<see cref="http://www.w3.org/2002/07/owl#members"/>
    ///</summary>
    public const string members = "http://www.w3.org/2002/07/owl#members";

    ///<summary>
    ///The property that determines the cardinality of a minimum cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minCardinality"/>
    ///</summary>
    public const string minCardinality = "http://www.w3.org/2002/07/owl#minCardinality";

    ///<summary>
    ///The property that determines the cardinality of a minimum qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#minQualifiedCardinality"/>
    ///</summary>
    public const string minQualifiedCardinality = "http://www.w3.org/2002/07/owl#minQualifiedCardinality";

    ///<summary>
    ///The property that determines the class that a qualified object cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onClass"/>
    ///</summary>
    public const string onClass = "http://www.w3.org/2002/07/owl#onClass";

    ///<summary>
    ///The property that determines the data range that a qualified data cardinality restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDataRange"/>
    ///</summary>
    public const string onDataRange = "http://www.w3.org/2002/07/owl#onDataRange";

    ///<summary>
    ///The property that determines the datatype that a datatype restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onDatatype"/>
    ///</summary>
    public const string onDatatype = "http://www.w3.org/2002/07/owl#onDatatype";

    ///<summary>
    ///The property that determines the collection of individuals or data values that build an enumeration.
    ///<see cref="http://www.w3.org/2002/07/owl#oneOf"/>
    ///</summary>
    public const string oneOf = "http://www.w3.org/2002/07/owl#oneOf";

    ///<summary>
    ///The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperties"/>
    ///</summary>
    public const string onProperties = "http://www.w3.org/2002/07/owl#onProperties";

    ///<summary>
    ///The property that determines the property that a property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#onProperty"/>
    ///</summary>
    public const string onProperty = "http://www.w3.org/2002/07/owl#onProperty";

    ///<summary>
    ///The annotation property that indicates the predecessor ontology of a given ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#priorVersion"/>
    ///</summary>
    public const string priorVersion = "http://www.w3.org/2002/07/owl#priorVersion";

    ///<summary>
    ///The property that determines the n-tuple of properties that build a sub property chain of a given property.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyChainAxiom"/>
    ///</summary>
    public const string propertyChainAxiom = "http://www.w3.org/2002/07/owl#propertyChainAxiom";

    ///<summary>
    ///The property that determines that two given properties are disjoint.
    ///<see cref="http://www.w3.org/2002/07/owl#propertyDisjointWith"/>
    ///</summary>
    public const string propertyDisjointWith = "http://www.w3.org/2002/07/owl#propertyDisjointWith";

    ///<summary>
    ///The property that determines the cardinality of an exact qualified cardinality restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#qualifiedCardinality"/>
    ///</summary>
    public const string qualifiedCardinality = "http://www.w3.org/2002/07/owl#qualifiedCardinality";

    ///<summary>
    ///The property that determines that two given individuals are equal.
    ///<see cref="http://www.w3.org/2002/07/owl#sameAs"/>
    ///</summary>
    public const string sameAs = "http://www.w3.org/2002/07/owl#sameAs";

    ///<summary>
    ///The property that determines the class that an existential property restriction refers to.
    ///<see cref="http://www.w3.org/2002/07/owl#someValuesFrom"/>
    ///</summary>
    public const string someValuesFrom = "http://www.w3.org/2002/07/owl#someValuesFrom";

    ///<summary>
    ///The property that determines the subject of a negative property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#sourceIndividual"/>
    ///</summary>
    public const string sourceIndividual = "http://www.w3.org/2002/07/owl#sourceIndividual";

    ///<summary>
    ///The property that determines the object of a negative object property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetIndividual"/>
    ///</summary>
    public const string targetIndividual = "http://www.w3.org/2002/07/owl#targetIndividual";

    ///<summary>
    ///The property that determines the value of a negative data property assertion.
    ///<see cref="http://www.w3.org/2002/07/owl#targetValue"/>
    ///</summary>
    public const string targetValue = "http://www.w3.org/2002/07/owl#targetValue";

    ///<summary>
    ///The data property that relates every individual to every data value.
    ///<see cref="http://www.w3.org/2002/07/owl#topDataProperty"/>
    ///</summary>
    public const string topDataProperty = "http://www.w3.org/2002/07/owl#topDataProperty";

    ///<summary>
    ///The object property that relates every two individuals.
    ///<see cref="http://www.w3.org/2002/07/owl#topObjectProperty"/>
    ///</summary>
    public const string topObjectProperty = "http://www.w3.org/2002/07/owl#topObjectProperty";

    ///<summary>
    ///The property that determines the collection of classes or data ranges that build a union.
    ///<see cref="http://www.w3.org/2002/07/owl#unionOf"/>
    ///</summary>
    public const string unionOf = "http://www.w3.org/2002/07/owl#unionOf";

    ///<summary>
    ///The annotation property that provides version information for an ontology or another OWL construct.
    ///<see cref="http://www.w3.org/2002/07/owl#versionInfo"/>
    ///</summary>
    public const string versionInfo = "http://www.w3.org/2002/07/owl#versionInfo";

    ///<summary>
    ///The property that identifies the version IRI of an ontology.
    ///<see cref="http://www.w3.org/2002/07/owl#versionIRI"/>
    ///</summary>
    public const string versionIRI = "http://www.w3.org/2002/07/owl#versionIRI";

    ///<summary>
    ///The property that determines the collection of facet-value pairs that define a datatype restriction.
    ///<see cref="http://www.w3.org/2002/07/owl#withRestrictions"/>
    ///</summary>
    public const string withRestrictions = "http://www.w3.org/2002/07/owl#withRestrictions";
}
///<summary>
///
///
///</summary>
public class cwa : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.sap-cwa-graph.com/rdf#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "cwa";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf"/>
    ///</summary>
    public static readonly Resource rdf = new Resource(new Uri("http://www.sap-cwa-graph.com/rdf"));    

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#code"/>
    ///</summary>
    public static readonly Property code = new Property(new Uri("http://www.sap-cwa-graph.com/rdf#code"));    

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#hasEncountered"/>
    ///</summary>
    public static readonly Property hasEncountered = new Property(new Uri("http://www.sap-cwa-graph.com/rdf#hasEncountered"));    

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#isInfected"/>
    ///</summary>
    public static readonly Property isInfected = new Property(new Uri("http://www.sap-cwa-graph.com/rdf#isInfected"));    

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#User"/>
    ///</summary>
    public static readonly Class User = new Class(new Uri("http://www.sap-cwa-graph.com/rdf#User"));
}
///<summary>
///
///
///</summary>
public static class CWA
{
    public static readonly Uri Namespace = new Uri("http://www.sap-cwa-graph.com/rdf#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "CWA";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf"/>
    ///</summary>
    public const string rdf = "http://www.sap-cwa-graph.com/rdf";

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#code"/>
    ///</summary>
    public const string code = "http://www.sap-cwa-graph.com/rdf#code";

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#hasEncountered"/>
    ///</summary>
    public const string hasEncountered = "http://www.sap-cwa-graph.com/rdf#hasEncountered";

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#isInfected"/>
    ///</summary>
    public const string isInfected = "http://www.sap-cwa-graph.com/rdf#isInfected";

    ///<summary>
    ///
    ///<see cref="http://www.sap-cwa-graph.com/rdf#User"/>
    ///</summary>
    public const string User = "http://www.sap-cwa-graph.com/rdf#User";
}
}