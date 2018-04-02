using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGPlaza.api;
using RPGPlaza.Models.SavageWorlds;
using RPGPlaza.Data;

namespace RPGPlaza.api
{
    /// <summary>
    /// API class for handling Savage Words data. Inherits and implemetns the ISWData nad ISWCharacter interfaces.
    /// </summary>
    public class SavageWorldsDataApi : ISWData, ISWCharacter
    {
        
        ApplicationDbContext context;        

        /// <summary>
        ///     Return information on a Savage Worlds book by its Id.
        /// </summary>
        /// <param name="id">DB Identity</param>
        /// <returns>SWBook found by id, or null if no match is found.</returns>
        public SWBook getBook(int id)
        {
            SWBook book = new SWBook();

            using (var db = context)
            {
                book = db.SWBooks
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
            }
            return book;
        }

        /// <summary>
        ///     Return information on a Savage Worlds book by its title.
        /// </summary>
        /// <param name="id">Book title</param>
        /// <returns>SWBook found by its title, or null if no match is found.</returns>
        public SWBook getBook(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWBook> getBooks()
        {
            throw new NotImplementedException();
        }

        public SWCharacter getCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWCharacter> getCharacters(string userId)
        {
            throw new NotImplementedException();
        }

        public SWEdge getEdge(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWEdge> getEdges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWEdge> getEdgesByBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWEdge> getEdgesByType(int typeId)
        {
            throw new NotImplementedException();
        }

        public SWEdgeType getEdgeTypes()
        {
            throw new NotImplementedException();
        }

        public SWHindrance getHindrance(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWHindrance> getHindrances()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWHindrance> getHindrancesByBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SWSkill> getSkills()
        {
            throw new NotImplementedException();
        }
    }
}
