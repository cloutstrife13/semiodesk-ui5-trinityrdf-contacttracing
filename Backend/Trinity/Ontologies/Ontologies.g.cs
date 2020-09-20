// Attention: This file is generated. Any modifications will eventually be overwritten.
// Date: 20/09/2020 21:19:33

using System;
using System.Collections.Generic;
using System.Text;
using Semiodesk.Trinity;

namespace ContactTracingGraph
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
public class crt : Ontology
{
    public static readonly Uri Namespace = new Uri("http://www.covid-rdf-tracker.com/graph#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "crt";
    public static string GetPrefix() { return Prefix; }     

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph"/>
    ///</summary>
    public static readonly Resource graph = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#BFLBQX"/>
    ///</summary>
    public static readonly Resource BFLBQX = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#BFLBQX"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#BPZJGG"/>
    ///</summary>
    public static readonly Resource BPZJGG = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#BPZJGG"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#BQKPSX"/>
    ///</summary>
    public static readonly Resource BQKPSX = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#BQKPSX"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CDPVQF"/>
    ///</summary>
    public static readonly Resource CDPVQF = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#CDPVQF"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CKQSYV"/>
    ///</summary>
    public static readonly Resource CKQSYV = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#CKQSYV"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CKXBAN"/>
    ///</summary>
    public static readonly Resource CKXBAN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#CKXBAN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#classification"/>
    ///</summary>
    public static readonly Property classification = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#classification"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CLCDJG"/>
    ///</summary>
    public static readonly Resource CLCDJG = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#CLCDJG"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#covidHealthLevel"/>
    ///</summary>
    public static readonly Property covidHealthLevel = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#covidHealthLevel"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#dateDiagnosed"/>
    ///</summary>
    public static readonly Property dateDiagnosed = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#dateDiagnosed"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#dateEncountered"/>
    ///</summary>
    public static readonly Property dateEncountered = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#dateEncountered"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DEBER"/>
    ///</summary>
    public static readonly Resource DEBER = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#DEBER"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DECGN"/>
    ///</summary>
    public static readonly Resource DECGN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#DECGN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DEMUC"/>
    ///</summary>
    public static readonly Resource DEMUC = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#DEMUC"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#diagnosis"/>
    ///</summary>
    public static readonly Property diagnosis = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#diagnosis"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DSPHLW"/>
    ///</summary>
    public static readonly Resource DSPHLW = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#DSPHLW"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DTRKNE"/>
    ///</summary>
    public static readonly Resource DTRKNE = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#DTRKNE"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DUWDWN"/>
    ///</summary>
    public static readonly Resource DUWDWN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#DUWDWN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#EAFMKE"/>
    ///</summary>
    public static readonly Resource EAFMKE = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#EAFMKE"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#EKGFKJ"/>
    ///</summary>
    public static readonly Resource EKGFKJ = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#EKGFKJ"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_DEBER"/>
    ///</summary>
    public static readonly Resource ENC_DEBER = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ENC_DEBER"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_DECGN"/>
    ///</summary>
    public static readonly Resource ENC_DECGN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ENC_DECGN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_DEMUC"/>
    ///</summary>
    public static readonly Resource ENC_DEMUC = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ENC_DEMUC"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_ENLDN"/>
    ///</summary>
    public static readonly Resource ENC_ENLDN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ENC_ENLDN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_ESBCN"/>
    ///</summary>
    public static readonly Resource ENC_ESBCN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ENC_ESBCN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_FRPAR"/>
    ///</summary>
    public static readonly Resource ENC_FRPAR = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ENC_FRPAR"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#encounter"/>
    ///</summary>
    public static readonly Property encounter = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#encounter"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#Encounter"/>
    ///</summary>
    public static readonly Class Encounter = new Class(new Uri("http://www.covid-rdf-tracker.com/graph#Encounter"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENLDN"/>
    ///</summary>
    public static readonly Resource ENLDN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ENLDN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ESBCN"/>
    ///</summary>
    public static readonly Resource ESBCN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ESBCN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#FRPAR"/>
    ///</summary>
    public static readonly Resource FRPAR = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#FRPAR"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#FXVJXS"/>
    ///</summary>
    public static readonly Resource FXVJXS = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#FXVJXS"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#GAXCXS"/>
    ///</summary>
    public static readonly Resource GAXCXS = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#GAXCXS"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#GWAXBD"/>
    ///</summary>
    public static readonly Resource GWAXBD = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#GWAXBD"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#HHGTCF"/>
    ///</summary>
    public static readonly Resource HHGTCF = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#HHGTCF"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#HZFLJF"/>
    ///</summary>
    public static readonly Resource HZFLJF = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#HZFLJF"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#InfectiousDisease"/>
    ///</summary>
    public static readonly Class InfectiousDisease = new Class(new Uri("http://www.covid-rdf-tracker.com/graph#InfectiousDisease"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#JCBVVF"/>
    ///</summary>
    public static readonly Resource JCBVVF = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#JCBVVF"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#KHMFHS"/>
    ///</summary>
    public static readonly Resource KHMFHS = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#KHMFHS"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#KLEDMH"/>
    ///</summary>
    public static readonly Resource KLEDMH = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#KLEDMH"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#LUZULZ"/>
    ///</summary>
    public static readonly Resource LUZULZ = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#LUZULZ"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#MMGPDN"/>
    ///</summary>
    public static readonly Resource MMGPDN = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#MMGPDN"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#NABKZM"/>
    ///</summary>
    public static readonly Resource NABKZM = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#NABKZM"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#name"/>
    ///</summary>
    public static readonly Property name = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#name"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#NDBXCL"/>
    ///</summary>
    public static readonly Resource NDBXCL = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#NDBXCL"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#NSTEBX"/>
    ///</summary>
    public static readonly Resource NSTEBX = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#NSTEBX"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#person"/>
    ///</summary>
    public static readonly Property person = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#person"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#Person"/>
    ///</summary>
    public static readonly Class Person = new Class(new Uri("http://www.covid-rdf-tracker.com/graph#Person"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#PGADMP"/>
    ///</summary>
    public static readonly Resource PGADMP = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#PGADMP"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#place"/>
    ///</summary>
    public static readonly Property place = new Property(new Uri("http://www.covid-rdf-tracker.com/graph#place"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#Place"/>
    ///</summary>
    public static readonly Class Place = new Class(new Uri("http://www.covid-rdf-tracker.com/graph#Place"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#PVTCUS"/>
    ///</summary>
    public static readonly Resource PVTCUS = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#PVTCUS"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#QCASYA"/>
    ///</summary>
    public static readonly Resource QCASYA = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#QCASYA"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#QCCLHW"/>
    ///</summary>
    public static readonly Resource QCCLHW = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#QCCLHW"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#QMTWAE"/>
    ///</summary>
    public static readonly Resource QMTWAE = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#QMTWAE"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#RATJEP"/>
    ///</summary>
    public static readonly Resource RATJEP = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#RATJEP"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#RNTQED"/>
    ///</summary>
    public static readonly Resource RNTQED = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#RNTQED"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#SQQTAZ"/>
    ///</summary>
    public static readonly Resource SQQTAZ = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#SQQTAZ"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#STRVYT"/>
    ///</summary>
    public static readonly Resource STRVYT = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#STRVYT"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#SXJMXE"/>
    ///</summary>
    public static readonly Resource SXJMXE = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#SXJMXE"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#TXMXJP"/>
    ///</summary>
    public static readonly Resource TXMXJP = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#TXMXJP"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ULKQUF"/>
    ///</summary>
    public static readonly Resource ULKQUF = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ULKQUF"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#UYPCAT"/>
    ///</summary>
    public static readonly Resource UYPCAT = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#UYPCAT"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#VJUAKW"/>
    ///</summary>
    public static readonly Resource VJUAKW = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#VJUAKW"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#VTGSHK"/>
    ///</summary>
    public static readonly Resource VTGSHK = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#VTGSHK"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#WFZDWR"/>
    ///</summary>
    public static readonly Resource WFZDWR = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#WFZDWR"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#WHCWPA"/>
    ///</summary>
    public static readonly Resource WHCWPA = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#WHCWPA"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#WUJVBR"/>
    ///</summary>
    public static readonly Resource WUJVBR = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#WUJVBR"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#XNMZNP"/>
    ///</summary>
    public static readonly Resource XNMZNP = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#XNMZNP"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#XPHVZD"/>
    ///</summary>
    public static readonly Resource XPHVZD = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#XPHVZD"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#XWDBGX"/>
    ///</summary>
    public static readonly Resource XWDBGX = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#XWDBGX"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#YJZTNH"/>
    ///</summary>
    public static readonly Resource YJZTNH = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#YJZTNH"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ZNSUGM"/>
    ///</summary>
    public static readonly Resource ZNSUGM = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ZNSUGM"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ZXRTUW"/>
    ///</summary>
    public static readonly Resource ZXRTUW = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ZXRTUW"));    

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ZYAGCY"/>
    ///</summary>
    public static readonly Resource ZYAGCY = new Resource(new Uri("http://www.covid-rdf-tracker.com/graph#ZYAGCY"));
}
///<summary>
///
///
///</summary>
public static class CRT
{
    public static readonly Uri Namespace = new Uri("http://www.covid-rdf-tracker.com/graph#");
    public static Uri GetNamespace() { return Namespace; }
    
    public static readonly string Prefix = "CRT";
    public static string GetPrefix() { return Prefix; } 

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph"/>
    ///</summary>
    public const string graph = "http://www.covid-rdf-tracker.com/graph";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#BFLBQX"/>
    ///</summary>
    public const string BFLBQX = "http://www.covid-rdf-tracker.com/graph#BFLBQX";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#BPZJGG"/>
    ///</summary>
    public const string BPZJGG = "http://www.covid-rdf-tracker.com/graph#BPZJGG";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#BQKPSX"/>
    ///</summary>
    public const string BQKPSX = "http://www.covid-rdf-tracker.com/graph#BQKPSX";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CDPVQF"/>
    ///</summary>
    public const string CDPVQF = "http://www.covid-rdf-tracker.com/graph#CDPVQF";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CKQSYV"/>
    ///</summary>
    public const string CKQSYV = "http://www.covid-rdf-tracker.com/graph#CKQSYV";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CKXBAN"/>
    ///</summary>
    public const string CKXBAN = "http://www.covid-rdf-tracker.com/graph#CKXBAN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#classification"/>
    ///</summary>
    public const string classification = "http://www.covid-rdf-tracker.com/graph#classification";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#CLCDJG"/>
    ///</summary>
    public const string CLCDJG = "http://www.covid-rdf-tracker.com/graph#CLCDJG";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#covidHealthLevel"/>
    ///</summary>
    public const string covidHealthLevel = "http://www.covid-rdf-tracker.com/graph#covidHealthLevel";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#dateDiagnosed"/>
    ///</summary>
    public const string dateDiagnosed = "http://www.covid-rdf-tracker.com/graph#dateDiagnosed";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#dateEncountered"/>
    ///</summary>
    public const string dateEncountered = "http://www.covid-rdf-tracker.com/graph#dateEncountered";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DEBER"/>
    ///</summary>
    public const string DEBER = "http://www.covid-rdf-tracker.com/graph#DEBER";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DECGN"/>
    ///</summary>
    public const string DECGN = "http://www.covid-rdf-tracker.com/graph#DECGN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DEMUC"/>
    ///</summary>
    public const string DEMUC = "http://www.covid-rdf-tracker.com/graph#DEMUC";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#diagnosis"/>
    ///</summary>
    public const string diagnosis = "http://www.covid-rdf-tracker.com/graph#diagnosis";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DSPHLW"/>
    ///</summary>
    public const string DSPHLW = "http://www.covid-rdf-tracker.com/graph#DSPHLW";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DTRKNE"/>
    ///</summary>
    public const string DTRKNE = "http://www.covid-rdf-tracker.com/graph#DTRKNE";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#DUWDWN"/>
    ///</summary>
    public const string DUWDWN = "http://www.covid-rdf-tracker.com/graph#DUWDWN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#EAFMKE"/>
    ///</summary>
    public const string EAFMKE = "http://www.covid-rdf-tracker.com/graph#EAFMKE";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#EKGFKJ"/>
    ///</summary>
    public const string EKGFKJ = "http://www.covid-rdf-tracker.com/graph#EKGFKJ";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_DEBER"/>
    ///</summary>
    public const string ENC_DEBER = "http://www.covid-rdf-tracker.com/graph#ENC_DEBER";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_DECGN"/>
    ///</summary>
    public const string ENC_DECGN = "http://www.covid-rdf-tracker.com/graph#ENC_DECGN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_DEMUC"/>
    ///</summary>
    public const string ENC_DEMUC = "http://www.covid-rdf-tracker.com/graph#ENC_DEMUC";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_ENLDN"/>
    ///</summary>
    public const string ENC_ENLDN = "http://www.covid-rdf-tracker.com/graph#ENC_ENLDN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_ESBCN"/>
    ///</summary>
    public const string ENC_ESBCN = "http://www.covid-rdf-tracker.com/graph#ENC_ESBCN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENC_FRPAR"/>
    ///</summary>
    public const string ENC_FRPAR = "http://www.covid-rdf-tracker.com/graph#ENC_FRPAR";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#encounter"/>
    ///</summary>
    public const string encounter = "http://www.covid-rdf-tracker.com/graph#encounter";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#Encounter"/>
    ///</summary>
    public const string Encounter = "http://www.covid-rdf-tracker.com/graph#Encounter";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ENLDN"/>
    ///</summary>
    public const string ENLDN = "http://www.covid-rdf-tracker.com/graph#ENLDN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ESBCN"/>
    ///</summary>
    public const string ESBCN = "http://www.covid-rdf-tracker.com/graph#ESBCN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#FRPAR"/>
    ///</summary>
    public const string FRPAR = "http://www.covid-rdf-tracker.com/graph#FRPAR";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#FXVJXS"/>
    ///</summary>
    public const string FXVJXS = "http://www.covid-rdf-tracker.com/graph#FXVJXS";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#GAXCXS"/>
    ///</summary>
    public const string GAXCXS = "http://www.covid-rdf-tracker.com/graph#GAXCXS";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#GWAXBD"/>
    ///</summary>
    public const string GWAXBD = "http://www.covid-rdf-tracker.com/graph#GWAXBD";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#HHGTCF"/>
    ///</summary>
    public const string HHGTCF = "http://www.covid-rdf-tracker.com/graph#HHGTCF";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#HZFLJF"/>
    ///</summary>
    public const string HZFLJF = "http://www.covid-rdf-tracker.com/graph#HZFLJF";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#InfectiousDisease"/>
    ///</summary>
    public const string InfectiousDisease = "http://www.covid-rdf-tracker.com/graph#InfectiousDisease";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#JCBVVF"/>
    ///</summary>
    public const string JCBVVF = "http://www.covid-rdf-tracker.com/graph#JCBVVF";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#KHMFHS"/>
    ///</summary>
    public const string KHMFHS = "http://www.covid-rdf-tracker.com/graph#KHMFHS";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#KLEDMH"/>
    ///</summary>
    public const string KLEDMH = "http://www.covid-rdf-tracker.com/graph#KLEDMH";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#LUZULZ"/>
    ///</summary>
    public const string LUZULZ = "http://www.covid-rdf-tracker.com/graph#LUZULZ";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#MMGPDN"/>
    ///</summary>
    public const string MMGPDN = "http://www.covid-rdf-tracker.com/graph#MMGPDN";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#NABKZM"/>
    ///</summary>
    public const string NABKZM = "http://www.covid-rdf-tracker.com/graph#NABKZM";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#name"/>
    ///</summary>
    public const string name = "http://www.covid-rdf-tracker.com/graph#name";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#NDBXCL"/>
    ///</summary>
    public const string NDBXCL = "http://www.covid-rdf-tracker.com/graph#NDBXCL";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#NSTEBX"/>
    ///</summary>
    public const string NSTEBX = "http://www.covid-rdf-tracker.com/graph#NSTEBX";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#person"/>
    ///</summary>
    public const string person = "http://www.covid-rdf-tracker.com/graph#person";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#Person"/>
    ///</summary>
    public const string Person = "http://www.covid-rdf-tracker.com/graph#Person";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#PGADMP"/>
    ///</summary>
    public const string PGADMP = "http://www.covid-rdf-tracker.com/graph#PGADMP";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#place"/>
    ///</summary>
    public const string place = "http://www.covid-rdf-tracker.com/graph#place";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#Place"/>
    ///</summary>
    public const string Place = "http://www.covid-rdf-tracker.com/graph#Place";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#PVTCUS"/>
    ///</summary>
    public const string PVTCUS = "http://www.covid-rdf-tracker.com/graph#PVTCUS";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#QCASYA"/>
    ///</summary>
    public const string QCASYA = "http://www.covid-rdf-tracker.com/graph#QCASYA";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#QCCLHW"/>
    ///</summary>
    public const string QCCLHW = "http://www.covid-rdf-tracker.com/graph#QCCLHW";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#QMTWAE"/>
    ///</summary>
    public const string QMTWAE = "http://www.covid-rdf-tracker.com/graph#QMTWAE";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#RATJEP"/>
    ///</summary>
    public const string RATJEP = "http://www.covid-rdf-tracker.com/graph#RATJEP";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#RNTQED"/>
    ///</summary>
    public const string RNTQED = "http://www.covid-rdf-tracker.com/graph#RNTQED";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#SQQTAZ"/>
    ///</summary>
    public const string SQQTAZ = "http://www.covid-rdf-tracker.com/graph#SQQTAZ";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#STRVYT"/>
    ///</summary>
    public const string STRVYT = "http://www.covid-rdf-tracker.com/graph#STRVYT";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#SXJMXE"/>
    ///</summary>
    public const string SXJMXE = "http://www.covid-rdf-tracker.com/graph#SXJMXE";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#TXMXJP"/>
    ///</summary>
    public const string TXMXJP = "http://www.covid-rdf-tracker.com/graph#TXMXJP";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ULKQUF"/>
    ///</summary>
    public const string ULKQUF = "http://www.covid-rdf-tracker.com/graph#ULKQUF";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#UYPCAT"/>
    ///</summary>
    public const string UYPCAT = "http://www.covid-rdf-tracker.com/graph#UYPCAT";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#VJUAKW"/>
    ///</summary>
    public const string VJUAKW = "http://www.covid-rdf-tracker.com/graph#VJUAKW";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#VTGSHK"/>
    ///</summary>
    public const string VTGSHK = "http://www.covid-rdf-tracker.com/graph#VTGSHK";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#WFZDWR"/>
    ///</summary>
    public const string WFZDWR = "http://www.covid-rdf-tracker.com/graph#WFZDWR";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#WHCWPA"/>
    ///</summary>
    public const string WHCWPA = "http://www.covid-rdf-tracker.com/graph#WHCWPA";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#WUJVBR"/>
    ///</summary>
    public const string WUJVBR = "http://www.covid-rdf-tracker.com/graph#WUJVBR";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#XNMZNP"/>
    ///</summary>
    public const string XNMZNP = "http://www.covid-rdf-tracker.com/graph#XNMZNP";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#XPHVZD"/>
    ///</summary>
    public const string XPHVZD = "http://www.covid-rdf-tracker.com/graph#XPHVZD";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#XWDBGX"/>
    ///</summary>
    public const string XWDBGX = "http://www.covid-rdf-tracker.com/graph#XWDBGX";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#YJZTNH"/>
    ///</summary>
    public const string YJZTNH = "http://www.covid-rdf-tracker.com/graph#YJZTNH";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ZNSUGM"/>
    ///</summary>
    public const string ZNSUGM = "http://www.covid-rdf-tracker.com/graph#ZNSUGM";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ZXRTUW"/>
    ///</summary>
    public const string ZXRTUW = "http://www.covid-rdf-tracker.com/graph#ZXRTUW";

    ///<summary>
    ///
    ///<see cref="http://www.covid-rdf-tracker.com/graph#ZYAGCY"/>
    ///</summary>
    public const string ZYAGCY = "http://www.covid-rdf-tracker.com/graph#ZYAGCY";
}
}