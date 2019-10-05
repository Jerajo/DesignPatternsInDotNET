namespace DesignPatterns.Services
{
	public interface IFileService
	{
			object Read(string filePath);
			void Write(string filePath, object document);
	}
}