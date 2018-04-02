using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGPlaza.Models.SavageWorlds;

namespace RPGPlaza.api
{
    /*
     *  Interface class to handle all calls for general Savage Worlds data  
     */     
    public interface ISWData
    {
        SWBook getBook(int id);  // return book by id
        SWBook getBook(string name);  // return book by name
        IEnumerable<SWBook> getBooks(); // return all books

        SWCharacter getCharacter(int id); // get character by int
        IEnumerable<SWCharacter> getCharacters(string userId); // get all characters for user of that id

        SWEdge getEdge(int id); // get edge by that id
        IEnumerable<SWEdge> getEdgesByType(int typeId); // get edge by EdgeTypeId
        IEnumerable<SWEdge> getEdges(); // return all edges
        IEnumerable<SWEdge> getEdgesByBook(int bookId); // return all edges by book

        SWEdgeType getEdgeTypes(); // return all edge types

        SWHindrance getHindrance(int id); // return hindrance by id
        IEnumerable<SWHindrance> getHindrances(); // return all hindrances
        IEnumerable<SWHindrance> getHindrancesByBook(int bookId); // return hindrances by book

        IEnumerable<SWSkill> getSkills(); // return all skills
    }

    /*
     *  Interface class to handle SWCharacter class CRUD data calls
     */ 
    public interface ISWCharacter
    {

    }
}

